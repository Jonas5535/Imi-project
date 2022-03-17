using Imi.Project.Api.Core.Dtos.Airport;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAirportService : IBaseService<AirportListResponseDto, AirportDetailResponseDto, AirportRequestDto>
    {
    }
}
