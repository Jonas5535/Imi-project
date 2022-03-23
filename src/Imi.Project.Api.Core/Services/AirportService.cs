using Imi.Project.Api.Core.Dtos.Airport;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportRepository;

        public AirportService(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public Task<AirportListResponseDto> AddAsync(AirportRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AirportDetailResponseDto> GetByIdAsync(Guid id)
        {
            Airport result = await _airportRepository.GetByIdAsync(id);
            AirportDetailResponseDto dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AirportListResponseDto>> ListAllAsync()
        {
            IEnumerable<Airport> result = await _airportRepository.ListAllAsync();
            IEnumerable<AirportListResponseDto> dto = result.MapToListDto();
            return dto;
        }

        public Task<AirportDetailResponseDto> UpdateAsync(AirportRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
