using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAirportService : IBaseService<AirportListResponseDto, AirportDetailResponseDto, AirportRequestDto>
    {
    }
}
