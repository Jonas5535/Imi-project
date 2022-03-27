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
    public class AirportService : IAirportService
    {

        private readonly IAirportRepository _airportRepository;
        private readonly IAircraftRepository _aircraftRepository;

        public AirportService(IAirportRepository airportRepository, IAircraftRepository aircraftRepository)
        {
            _airportRepository = airportRepository;
            _aircraftRepository = aircraftRepository;
        }

        public async Task<AirportListResponseDto> AddAsync(AirportRequestDto requestDto)
        {
            AirportListResponseDto dto = new AirportListResponseDto();
            IQueryable<Airport> airports = _airportRepository.GetAll();

            if (requestDto.Id != new Guid() && airports.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddBadRequest($"Airport with id {requestDto.Id} already exists");
                return dto;
            }

            if (airports.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)))
            {
                dto.AddBadRequest($"Airport with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            Airport airportEntity = requestDto.MapToEntity();
            airportEntity.AddedOn = DateTime.Now;
            airportEntity.ModifiedOn = DateTime.Now;
            await _airportRepository.AddAsync(airportEntity);

            dto = airportEntity.MapToListDtoSingle();
            return dto;
        }

        public async Task<BaseDto> DeleteAsync(Guid id)
        {
            BaseDto dto = new BaseDto();

            if (!_airportRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No airport with id {id} exists");
                return dto;
            }

            if (_aircraftRepository.GetAll().Any(a => a.SpottedAtAirports.Any(aa => aa.AirportId.Equals(id))))
            {
                dto.AddBadRequest("Cannot delete this airport because there are still aircraft coupled to it. Please uncouple all coupled aircrafts first.");
                return dto;
            }

            await _airportRepository.DeleteAsync(id);
            return dto;
        }

        public async Task<AirportDetailResponseDto> GetByIdAsync(Guid id)
        {
            AirportDetailResponseDto dto = new AirportDetailResponseDto();

            if (!_airportRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No airports with id {id} exist");
                return dto;
            }

            Airport result = await _airportRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AirportListResponseDto>> ListAllAsync()
        {
            IEnumerable<Airport> result = await _airportRepository.ListAllAsync();

            IEnumerable<AirportListResponseDto> dtos = result.OrderByDescending(a => a.ModifiedOn).MapToListDto();
            return dtos;
        }

        public async Task<AirportDetailResponseDto> UpdateAsync(AirportRequestDto requestDto)
        {
            AirportDetailResponseDto dto = new AirportDetailResponseDto();
            IQueryable<Airport> airports = _airportRepository.GetAll();

            if (!airports.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddNotFound($"No Airport with id {requestDto.Id} exists");
                return dto;
            }

            // Checking if the user isn't changing the icao code to something that already exist,
            // while making sure it doesn't throw an error because the user didn't change the icao code
            Airport currentAirport = airports.Where(a => a.Id.Equals(requestDto.Id)).FirstOrDefault();
            if (airports.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)) && requestDto.ICAOCode != currentAirport.ICAOCode)
            {
                dto.AddConflict($"Record with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            Airport airportEntity = requestDto.MapToEntity();
            airportEntity.AddedOn = currentAirport.AddedOn;
            airportEntity.ModifiedOn = DateTime.Now;
            await _airportRepository.UpdateAsync(airportEntity);

            dto = airportEntity.MapToDetailDto();
            return dto;
        }
    }
}
