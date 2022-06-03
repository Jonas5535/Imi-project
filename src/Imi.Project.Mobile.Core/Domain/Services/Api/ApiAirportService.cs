using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAirportService : IAirportService
    {
        private readonly string _baseEndpoint;

        public ApiAirportService()
        {
            _baseEndpoint = "airports";
        }

        public async Task<BaseResponse<Airport>> AddAsync(Airport entity)
        {
            BaseResponse<Airport> response = await WebApiClient.PostCallApi<Airport, Airport>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<Airport>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<Airport>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<Airport>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<Airport>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<ICollection<Airport>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<ICollection<Airport>>(_baseEndpoint);
        }

        public async Task<BaseResponse<Airport>> UpdateAsync(Airport entity)
        {
            return await WebApiClient.PutCallApi<Airport, Airport>(_baseEndpoint, entity);
        }
    }
}
