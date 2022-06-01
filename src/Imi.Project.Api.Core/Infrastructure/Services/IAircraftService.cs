using Imi.Project.Api.Core.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAircraftService : IBaseService<AircraftListResponseDto, AircraftDetailResponseDto, AircraftRequestDto>
    {
        Task<IEnumerable<AircraftListResponseDto>> FilterAsync(bool? hasSpecialLivery, string registration, string type, string airlineName, string airportName);
        Task<AircraftListResponseDto> AddOrUpdateImageAsync(Guid id, IFormFile file);
    }
}
