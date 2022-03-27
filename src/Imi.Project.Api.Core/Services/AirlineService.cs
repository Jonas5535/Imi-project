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
    public class AirlineService : IAirlineService
    {
        private readonly IAirlineRepository _airlineRepository;
        private readonly IAircraftRepository _aircraftRepository;

        public AirlineService(IAirlineRepository airlineRepository, IAircraftRepository aircraftRepository)
        {
            _airlineRepository = airlineRepository;
            _aircraftRepository = aircraftRepository;
        }

        public async Task<AirlineListResponseDto> AddAsync(AirlineRequestDto requestDto)
        {
            AirlineListResponseDto dto = new AirlineListResponseDto();
            IQueryable<Airline> airlines = _airlineRepository.GetAll();

            if (requestDto.Id != new Guid() && airlines.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddBadRequest($"Airline with id {requestDto.Id} already exists");
                return dto;
            }

            if (airlines.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)))
            {
                dto.AddBadRequest($"Airline with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            Airline airlineEntity = requestDto.MapToEntity();
            airlineEntity.AddedOn = DateTime.Now;
            airlineEntity.ModifiedOn = DateTime.Now;
            await _airlineRepository.AddAsync(airlineEntity);

            dto = airlineEntity.MapToListDtoSingle();
            return dto;
        }

        public async Task<BaseDto> DeleteAsync(Guid id)
        {
            BaseDto dto = new BaseDto();

            if (!_airlineRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No airline with id {id} exists");
                return dto;
            }

            if (_aircraftRepository.GetAll().Any(a => a.AirlineId.Equals(id)))
            {
                dto.AddBadRequest("Cannot delete this airline because there are still aircraft coupled to it. Please uncouple all coupled aircrafts first.");
                return dto;
            }

            await _airlineRepository.DeleteAsync(id);
            return dto;
        }

        public async Task<AirlineDetailResponseDto> GetByIdAsync(Guid id)
        {
            AirlineDetailResponseDto dto = new AirlineDetailResponseDto();

            if (!_airlineRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No airlines with id {id} exist");
                return dto;
            }

            Airline result = await _airlineRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AirlineListResponseDto>> ListAllAsync()
        {
            IEnumerable<Airline> result = await _airlineRepository.ListAllAsync();
            IEnumerable<AirlineListResponseDto> dtos = result.OrderByDescending(a => a.ModifiedOn).MapToListDto();
            return dtos;
        }

        public async Task<AirlineDetailResponseDto> UpdateAsync(AirlineRequestDto requestDto)
        {
            AirlineDetailResponseDto dto = new AirlineDetailResponseDto();
            IQueryable<Airline> airlines = _airlineRepository.GetAll();

            if (!airlines.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddNotFound($"No airline with id {requestDto.Id} exists");
                return dto;
            }

            // Checking if the user isn't changing the icao code to something that already exist,
            // while making sure it doesn't throw an error because the user didn't change the icao code
            Airline currentAirline = airlines.FirstOrDefault(a => a.Id.Equals(requestDto.Id));
            if (airlines.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)) && requestDto.ICAOCode != currentAirline.ICAOCode)
            {
                dto.AddConflict($"Record with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            Airline airlineEntity = requestDto.MapToEntity();
            airlineEntity.AddedOn = currentAirline.AddedOn;
            airlineEntity.ModifiedOn = DateTime.Now;
            await _airlineRepository.UpdateAsync(airlineEntity);

            dto = airlineEntity.MapToDetailDto();
            return dto;
        }
    }
}
