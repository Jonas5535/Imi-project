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

        public AirlineService(IAirlineRepository airlineRepository)
        {
            _airlineRepository = airlineRepository;
        }

        public async Task<AirlineListResponseDto> AddAsync(AirlineRequestDto requestDto)
        {
            AirlineListResponseDto dto = new AirlineListResponseDto();
            IQueryable<Airline> airlines = _airlineRepository.GetAll();

            if (requestDto.Id !=  new Guid() && airlines.Any(a => a.Id.Equals(requestDto.Id)))
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
            //TODO Add check for existing id
            await _airlineRepository.DeleteAsync(id);
            return null;
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
            Airline airlineEntity = requestDto.MapToEntity();

            //TODO Add errorhandling

            airlineEntity.ModifiedOn = DateTime.Now;
            await _airlineRepository.UpdateAsync(airlineEntity);

            AirlineDetailResponseDto dto = airlineEntity.MapToDetailDto();
            return dto;
        }
    }
}
