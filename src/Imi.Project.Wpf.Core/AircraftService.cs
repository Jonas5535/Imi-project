using Imi.Project.Shared;
using Imi.Project.Wpf.Core.ApiModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
            HttpResponseMessage apiResponse;

            try
            {
                apiResponse = await _httpClient.GetAsync(_aircraftEndpoint);
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                return response;
            }

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAircraftListResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<ApiAircraftDetailResponse>> GetByIdAsync(string id)
        {
            ApiBaseResponse<ApiAircraftDetailResponse> response = new();
            HttpResponseMessage apiResponse;

            try
            {
                apiResponse = await _httpClient.GetAsync($"{_aircraftEndpoint}/{id}");
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                return response;
            }

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<ApiAircraftDetailResponse>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<object>> DeleteAsync(string id)
        {
            ApiBaseResponse<object> response = new();
            HttpResponseMessage deleteRequest;

            try
            {
                deleteRequest = await _httpClient.DeleteAsync($"{_aircraftEndpoint}/{id}");
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het verwijderen van de data";
                return response;
            }

            if (deleteRequest.IsSuccessStatusCode)
            {
                response.Status = deleteRequest.StatusCode;
                return response;
            }

            using Stream responseStream = await deleteRequest.Content.ReadAsStreamAsync();

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = deleteRequest.StatusCode;
            response.Reason = deleteRequest.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAirlineResponse>>> GetAirlines()
        {
            ApiBaseResponse<IEnumerable<ApiAirlineResponse>> response = new();
            HttpResponseMessage apiResponse;

            try
            {
                apiResponse = await _httpClient.GetAsync("Airlines");
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                return response;
            }

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAirlineResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAirportResponse>>> GetAirports()
        {
            ApiBaseResponse<IEnumerable<ApiAirportResponse>> response = new();
            HttpResponseMessage apiResponse;

            try
            {
                apiResponse = await _httpClient.GetAsync("Airports");
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                return response;
            }

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAirportResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<IEnumerable<ApiAircraftTypeResponse>>> GetAircraftTypes()
        {
            ApiBaseResponse<IEnumerable<ApiAircraftTypeResponse>> response = new();
            HttpResponseMessage apiResponse;

            try
            {
                apiResponse = await _httpClient.GetAsync("AircraftTypes");
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                return response;
            }

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();

            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAircraftTypeResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }

        public async Task<ApiBaseResponse<object>> AddAsync(ApiAircraftRequest aircraft)
        {
            ApiBaseResponse<object> response = new();
            HttpResponseMessage addRequest;

            string serializedContent = JsonSerializer.Serialize(aircraft);
            StringContent content = new StringContent(serializedContent);

            try
            {
                addRequest = await _httpClient.PostAsync(_aircraftEndpoint, content);
            }
            catch (HttpRequestException ex)
            {
                response.Status = HttpStatusCode.ServiceUnavailable;
                response.Reason = "Server niet beschikbaar";
                response.ErrorMessage = ex.Message;
                return response;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
                response.Reason = "Fout!";
                response.ErrorMessage = "Er is iets misgelopen tijdens het opslaan van de data";
                return response;
            }

            if (addRequest.IsSuccessStatusCode)
            {
                response.Status = addRequest.StatusCode;
                return response;
            }

            using Stream responseStream = await addRequest.Content.ReadAsStreamAsync();

            string errorMessage;
            using (StreamReader reader = new(responseStream))
            {
                errorMessage = await reader.ReadToEndAsync();
            }

            response.Status = addRequest.StatusCode;
            response.Reason = addRequest.ReasonPhrase;
            response.ErrorMessage = errorMessage;
            return response;
        }
    }
}
