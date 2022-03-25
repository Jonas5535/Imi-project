using Imi.Project.Api.Core.Dtos.Aircraft;
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

        public AircraftService(IAircraftRepository aircraftRepository)
        {
            _aircraftRepository = aircraftRepository;
        }

        public async Task<AircraftListResponseDto> AddAsync(AircraftRequestDto requestDto)
        {
            Aircraft aircraftEntity = requestDto.MapToEntity();

            //TODO Add errorhandling

            aircraftEntity.AddedOn = DateTime.Now;
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.AddAsync(aircraftEntity);

            // Get the just added aircraft from the database so the airline, aircrafttype and airport props are filled in so it can be shown in the result.
            aircraftEntity = _aircraftRepository.GetAll().SingleOrDefault(i => i.Id == aircraftEntity.Id);
            AircraftListResponseDto dto = aircraftEntity.MaptoListDtoSingle();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            //TODO Check if id exists
            await _aircraftRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AircraftListResponseDto>> FilterAsync(bool? hasSpecialLivery, string registration, string type, string airlineName, string airportName)
        {
            IEnumerable<Aircraft> aircrafts = await _aircraftRepository.FilterAsync(hasSpecialLivery, registration, type, airlineName, airportName);
            IEnumerable<AircraftListResponseDto> dtos = aircrafts.MapToListDto();
            return dtos;
        }

        public async Task<AircraftDetailResponseDto> GetByIdAsync(Guid id)
        {
            //TODO Check if id exists
            Aircraft result = await _aircraftRepository.GetByIdAsync(id);
            AircraftDetailResponseDto dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AircraftListResponseDto>> ListAllAsync()
        {
            IEnumerable<Aircraft> result = await _aircraftRepository.ListAllAsync();
            IEnumerable<AircraftListResponseDto> dtos = result.MapToListDto();
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
