﻿using Imi.Project.Wpf.Core.ApiModels;
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
            var response = new ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>();

            HttpResponseMessage apiResponse = await _httpClient.GetAsync(_aircraftEndpoint);

            using Stream responseStream = await apiResponse.Content.ReadAsStreamAsync();
            
            if (apiResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = await JsonSerializer.DeserializeAsync<IEnumerable<ApiAircraftListResponse>>(responseStream);

                response.Data = deserializedResponse;
                response.Status = apiResponse.StatusCode;
                return response;
            }

            var deserializedErrorMessage = await JsonSerializer.DeserializeAsync<string>(responseStream);

            response.Status = apiResponse.StatusCode;
            response.Reason = apiResponse.ReasonPhrase;
            response.ErrorMessage = deserializedErrorMessage;
            return response;
        }
    }
}
