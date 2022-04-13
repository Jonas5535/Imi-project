using Imi.Project.Wpf.Core.ApiModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core
{
    public class AircraftService : IAircraftService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClient;
        private const string _aircraftEndpoint = "Aircrafts";

        public AircraftService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(ApiBaseUri.ApiBaseAddress);
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>> ListAllAsync()
        {
            ApiBaseResponse<IEnumerable<ApiAircraftListResponse>> response = new();

            HttpResponseMessage apiResponse = await _httpClient.GetAsync(_aircraftEndpoint);

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAircraftListResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string deserializedErrorMessage = await JsonSerializer.DeserializeAsync<string>(responseStream);

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = deserializedErrorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<ApiAircraftDetailResponse>> GetByIdAsync(string id)
        {
            ApiBaseResponse<ApiAircraftDetailResponse> response = new();

            HttpResponseMessage apiResponse = await _httpClient.GetAsync($"{_aircraftEndpoint}/{id}");

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<ApiAircraftDetailResponse>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string deserializedErrorMessage = await JsonSerializer.DeserializeAsync<string>(responseStream);

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = deserializedErrorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<object>> DeleteAsync(string id)
        {
            ApiBaseResponse<object> response = new();

            HttpResponseMessage deleteRequest = await _httpClient.DeleteAsync($"{_aircraftEndpoint}/{id}");

            if (deleteRequest.IsSuccessStatusCode)
            {
                response.Status = deleteRequest.StatusCode;
                return response;
            }

            using Stream responseStream = await deleteRequest.Content.ReadAsStreamAsync();
            string deserializedErrorMessage = await JsonSerializer.DeserializeAsync<string>(responseStream);

            response.Status = deleteRequest.StatusCode;
            response.Reason = deleteRequest.ReasonPhrase;
            response.ErrorMessage = deserializedErrorMessage;
            return response;
        }
    }
}
