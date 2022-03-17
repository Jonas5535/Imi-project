using Imi.Project.Api.Core.Dtos.Aircraft;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAircraftService : IBaseService<AircraftListResponseDto, AircraftDetailResponseDto, AircraftRequestDto>
    {
    }
}
