using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using System;
using System.Collections.Generic;
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
            Airline airlineEntity = requestDto.MapToEntity();

            //TODO Add errorhandling

            airlineEntity.AddedOn = DateTime.Now;
            airlineEntity.ModifiedOn = DateTime.Now;
            await _airlineRepository.AddAsync(airlineEntity);

            AirlineListResponseDto dto = airlineEntity.MapToListDtoSingle();
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
            Airline result = await _airlineRepository.GetByIdAsync(id);
            AirlineDetailResponseDto dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AirlineListResponseDto>> ListAllAsync()
        {
            IEnumerable<Airline> result = await _airlineRepository.ListAllAsync();
            IEnumerable<AirlineListResponseDto> dtos = result.MapToListDto();
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
