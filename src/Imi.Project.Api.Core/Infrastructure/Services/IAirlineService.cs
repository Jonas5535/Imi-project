using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAirlineService : IBaseService<AirlineListResponseDto, AirlineDetailResponseDto, AirlineRequestDto>
    {
    }
}
