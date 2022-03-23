using Imi.Project.Api.Core.Dtos.Airline;
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

        public Task<AirlineListResponseDto> AddAsync(AirlineRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
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
            IEnumerable<AirlineListResponseDto> dto = result.MapToListDto();
            return dto;
        }

        public Task<AirlineDetailResponseDto> UpdateAsync(AirlineRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
