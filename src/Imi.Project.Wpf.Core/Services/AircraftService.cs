using Imi.Project.Wpf.Core.ApiModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly string _baseEndpoint;

        public AircraftService()
        {
            _baseEndpoint = "aircrafts";
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<IEnumerable<ApiAircraftListResponse>>(_baseEndpoint);
        }

        public async Task<ApiBaseResponse<ApiAircraftDetailResponse>> GetByIdAsync(string id)
        {
            return await WebApiClient.GetApiResult<ApiAircraftDetailResponse>($"{_baseEndpoint}/{id}");
        }

        public async Task<ApiBaseResponse<ApiAircraftListResponse>> DeleteAsync(string id)
        {
            return await WebApiClient.DeleteCallApi<ApiAircraftListResponse>($"{_baseEndpoint}/{id}");
        }

        public async Task<ApiBaseResponse<ApiAirlineResponse[]>> GetAirlines()
        {
            return await WebApiClient.GetApiResult<ApiAirlineResponse[]>("airlines");
        }

        public async Task<ApiBaseResponse<ApiAirportResponse[]>> GetAirports()
        {
            return await WebApiClient.GetApiResult<ApiAirportResponse[]>("airports");
        }

        public async Task<ApiBaseResponse<ApiAircraftTypeResponse[]>> GetAircraftTypes()
        {
            return await WebApiClient.GetApiResult<ApiAircraftTypeResponse[]>("aircraftTypes");
        }

        public async Task<ApiBaseResponse<ApiAircraftListResponse>> AddAsync(ApiAircraftRequest aircraft)
        {
            return await WebApiClient.PostCallApi<ApiAircraftListResponse, ApiAircraftRequest>(_baseEndpoint, aircraft);
        }

        public async Task<ApiBaseResponse<ApiAircraftListResponse>> UpdateAsync(ApiAircraftRequest aircraft)
        {
            return await WebApiClient.PutCallApi<ApiAircraftListResponse, ApiAircraftRequest>(_baseEndpoint, aircraft);
        }
    }
}
