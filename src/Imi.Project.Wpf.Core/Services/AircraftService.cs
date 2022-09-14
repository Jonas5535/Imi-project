using Imi.Project.Wpf.Core.ApiModels;
using System;
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

        public async Task<ApiBaseResponse<IEnumerable<ApiAirlineResponse>>> GetAirlines()
        {
            throw new NotImplementedException();
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAirportResponse>>> GetAirports()
        {
            throw new NotImplementedException();
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAircraftTypeResponse>>> GetAircraftTypes()
        {
            throw new NotImplementedException();
        }

        //public async Task<ApiBaseResponse<object>> AddAsync(ApiAircraftRequest aircraft)
        //{
        //    ApiBaseResponse<object> response = new();
        //    HttpResponseMessage addRequest;

        //    string serializedContent = JsonSerializer.Serialize(aircraft);
        //    StringContent content = new StringContent(serializedContent);

        //    try
        //    {
        //        addRequest = await _httpClient.PostAsync(_aircraftEndpoint, content);
        //    }
        //    catch (HttpRequestException ex)
        //    {
        //        response.Status = HttpStatusCode.ServiceUnavailable;
        //        response.Status = "Server niet beschikbaar";
        //        response.ErrorMessage = ex.Message;
        //        return response;
        //    }
        //    catch (Exception)
        //    {
        //        response.Status = HttpStatusCode.InternalServerError;
        //        response.Status = "Fout!";
        //        response.ErrorMessage = "Er is iets misgelopen tijdens het opslaan van de data";
        //        return response;
        //    }

        //    if (addRequest.IsSuccessStatusCode)
        //    {
        //        response.Status = addRequest.StatusCode;
        //        response.Status = addRequest.ReasonPhrase;
        //        return response;
        //    }

        //    using Stream responseStream = await addRequest.Content.ReadAsStreamAsync();

        //    string errorMessage;
        //    using (StreamReader reader = new(responseStream))
        //    {
        //        errorMessage = await reader.ReadToEndAsync();
        //    }

        //    response.Status = addRequest.StatusCode;
        //    response.Status = addRequest.ReasonPhrase;
        //    response.ErrorMessage = errorMessage;
        //    return response;
        //}
    }
}
