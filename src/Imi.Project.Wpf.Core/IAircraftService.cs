using Imi.Project.Wpf.Core.ApiModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core
{
    public interface IAircraftService
    {
        Task<ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>> ListAllAsync();
        Task<ApiBaseResponse<ApiAircraftDetailResponse>> GetByIdAsync(string id);
        Task<ApiBaseResponse<object>> DeleteAsync(string id);
        Task<ApiBaseResponse<IEnumerable<ApiAirlineResponse>>> GetAirlines();
        Task<ApiBaseResponse<IEnumerable<ApiAirportResponse>>> GetAirports();
        Task<ApiBaseResponse<IEnumerable<ApiAircraftTypeResponse>>> GetAircraftTypes();
        Task<ApiBaseResponse<object>> AddAsync(ApiAircraftRequest aircraft);
    }
}