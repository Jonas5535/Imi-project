using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly IAircraftRepository _aircraftRepository;
        private readonly IAircraftTypeRepository _aircraftTypeRepository;
        private readonly IAirlineRepository _airlineRepository;
        private readonly IAirportRepository _airportRepository;

        public AircraftService(IAircraftRepository aircraftRepository, IAircraftTypeRepository aircraftTypeRepository, IAirlineRepository airlineRepository, IAirportRepository airportRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftTypeRepository = aircraftTypeRepository;
            _airlineRepository = airlineRepository;
            _airportRepository = airportRepository;
        }

        public async Task<AircraftListResponseDto> AddAsync(AircraftRequestDto requestDto)
        {
            AircraftListResponseDto dto = new AircraftListResponseDto();
            IQueryable<Aircraft> aircrafts = _aircraftRepository.GetAll();


            if (requestDto.Id != new Guid() && aircrafts.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddBadRequest($"Aircraft with id {requestDto.Id} already exists");
                return dto;
            }

            if (aircrafts.Any(a => a.Registration.Equals(requestDto.Registration)))
            {
                dto.AddBadRequest($"Aircraft with registration {requestDto.Registration} already exists");
                return dto;
            }

            if (requestDto.FirstSeen > DateTime.Today)
            {
                dto.AddBadRequest($"The date of first seen cannot be later than {DateTime.Today.ToShortDateString()}");
                return dto;
            }

            if (requestDto.LastSeen < requestDto.FirstSeen || requestDto.LastSeen > DateTime.Today)
            {
                dto.AddBadRequest($"The date of last seen cannot be earlier than the date of first seen and cannot be later than {DateTime.Today.ToShortDateString()}");
                return dto;
            }

            if (!_aircraftTypeRepository.GetAll().Any(a => a.Id.Equals(requestDto.AircraftTypeId)))
            {
                dto.AddNotFound($"The aircraftType with id {requestDto.AircraftTypeId} does not exist. Please select an existing aircrafttype");
                return dto;
            }

            if (!_airlineRepository.GetAll().Any(a => a.Id.Equals(requestDto.AirlineId)))
            {
                dto.AddNotFound($"The airline with id {requestDto.AirlineId} does not exist. Please select an existing airline.");
                return dto;
            }

            if (requestDto.AirportIds.Count == 0)
            {
                dto.AddBadRequest("The list of coupled airports cannot be empty, please select at least one airport");
                return dto;
            }

            if (requestDto.AirportIds.Count != requestDto.AirportIds.Distinct().Count())
            {
                dto.AddBadRequest($"An airport cannot be added twice, please remove any duplicate airport ids from the list");
                return dto;
            }

            foreach (var airportId in requestDto.AirportIds)
            {
                if (!_airportRepository.GetAll().Any(a => a.Id.Equals(airportId)))
                {
                    dto.AddNotFound($"The airport with id {airportId} does not exist. Please select existing airports");
                    return dto;
                }
            }

            Aircraft aircraftEntity = requestDto.MapToEntity();
            aircraftEntity.AddedOn = DateTime.Now;
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.AddAsync(aircraftEntity);

            // Get the just added aircraft from the database so the airline, aircrafttype and airport props are filled in so it can be shown in the result.
            aircraftEntity = _aircraftRepository.GetAll().SingleOrDefault(i => i.Id == aircraftEntity.Id);
            dto = aircraftEntity.MaptoListDtoSingle();
            return dto;
        }

        public async Task<BaseDto> DeleteAsync(Guid id)
        {
            //TODO Check if id exists
            await _aircraftRepository.DeleteAsync(id);
            return null;
        }

        public async Task<IEnumerable<AircraftListResponseDto>> FilterAsync(bool? hasSpecialLivery, string registration, string type, string airlineName, string airportName)
        {
            IEnumerable<Aircraft> aircrafts = await _aircraftRepository.FilterAsync(hasSpecialLivery, registration, type, airlineName, airportName);

            if (!aircrafts.Any())
            {
                List<AircraftListResponseDto> dtoList = new List<AircraftListResponseDto>();
                AircraftListResponseDto dto = new AircraftListResponseDto();
                dto.AddNotFound("There were no aircrafts found that meet your search requirements");
                dtoList.Add(dto);
                return dtoList;
            }

            IEnumerable<AircraftListResponseDto> dtos = aircrafts.MapToListDto();
            return dtos;
        }

        public async Task<AircraftDetailResponseDto> GetByIdAsync(Guid id)
        {
            AircraftDetailResponseDto dto = new AircraftDetailResponseDto();

            if (!_aircraftRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No aircrafts with id {id} exist");
                return dto;
            }

            Aircraft result = await _aircraftRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AircraftListResponseDto>> ListAllAsync()
        {
            IEnumerable<Aircraft> result = await _aircraftRepository.ListAllAsync();

            IEnumerable<AircraftListResponseDto> dtos = result.OrderByDescending(a => a.ModifiedOn).MapToListDto();
            return dtos;
        }

        public async Task<AircraftDetailResponseDto> UpdateAsync(AircraftRequestDto requestDto)
        {
            Aircraft aircraftEntity = requestDto.MapToEntity();

            //TODO Add errorhandling
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.UpdateAsync(aircraftEntity);

            //TODO Fix bug where airports don't update
            // Get the just added aircraft from the database so the airline, aircrafttype and airport props are filled in so it can be shown in the result.
            aircraftEntity = _aircraftRepository.GetAll().SingleOrDefault(i => i.Id == aircraftEntity.Id);
            AircraftDetailResponseDto dto = aircraftEntity.MapToDetailDto();
            return dto;
        }
    }
}
