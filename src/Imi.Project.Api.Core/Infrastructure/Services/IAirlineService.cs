using Imi.Project.Api.Core.Dtos.Airline;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IAirlineService : IBaseService<AirlineListResponseDto, AirlineDetailResponseDto, AirlineRequestDto>
    {
    }
}
