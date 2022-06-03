using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAirlineService : IAirlineService
    {
        private readonly string _baseEndpoint;

        public ApiAirlineService()
        {
            _baseEndpoint = "airlines";
        }

        public async Task<BaseResponse<Airline>> AddAsync(Airline entity)
        {
            BaseResponse<Airline> response = await WebApiClient.PostCallApi<Airline, Airline>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<Airline>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<Airline>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<Airline>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<Airline>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<ICollection<Airline>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<ICollection<Airline>>(_baseEndpoint);
        }

        public async Task<BaseResponse<Airline>> UpdateAsync(Airline entity)
        {
            return await WebApiClient.PutCallApi<Airline, Airline>(_baseEndpoint, entity);
        }
    }
}
