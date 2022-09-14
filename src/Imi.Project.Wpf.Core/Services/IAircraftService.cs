using Imi.Project.Wpf.Core.ApiModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services
{
    public interface IAircraftService
    {
        Task<ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>> ListAllAsync();
        Task<ApiBaseResponse<ApiAircraftDetailResponse>> GetByIdAsync(string id);
        Task<ApiBaseResponse<ApiAircraftListResponse>> DeleteAsync(string id);
        Task<ApiBaseResponse<ApiAirlineResponse[]>> GetAirlines();
        Task<ApiBaseResponse<ApiAirportResponse[]>> GetAirports();
        Task<ApiBaseResponse<ApiAircraftTypeResponse[]>> GetAircraftTypes();
        Task<ApiBaseResponse<ApiAircraftListResponse>> AddAsync(ApiAircraftRequest aircraft);
        Task<ApiBaseResponse<ApiAircraftListResponse>> UpdateAsync(ApiAircraftRequest aircraft);
    }
}