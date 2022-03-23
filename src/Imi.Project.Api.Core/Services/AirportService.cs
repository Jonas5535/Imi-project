using Imi.Project.Api.Core.Dtos.Airport;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
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

        public Task<AirportDetailResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AirportListResponseDto>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AirportDetailResponseDto> UpdateAsync(AirportRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
