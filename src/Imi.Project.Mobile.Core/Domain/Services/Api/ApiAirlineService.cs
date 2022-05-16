using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAirlineService : ICRUDService<Airline>
    {
        private readonly string _baseEndpoint;

        public ApiAirlineService()
        {
            _baseEndpoint = "airlines";
        }

        public async Task<BaseResponse<Airline>> AddAsync(Airline entity)
        {
            BaseResponse<Airline> response = await WebApiClient.PostCallApi<BaseResponse<Airline>, Airline>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<Airline>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<BaseResponse<Airline>>($"{_baseEndpoint}/{id}");
        }

        public Task<AircraftType[]> GetAircraftTypes()
        {
            throw new NotImplementedException();
        }

        public Task<Airline[]> GetAirlines()
        {
            throw new NotImplementedException();
        }

        public Task<Airport[]> GetAirports()
        {
            throw new NotImplementedException();
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
            return await WebApiClient.PutCallApi<BaseResponse<Airline>, Airline>(_baseEndpoint, entity);
        }
    }
}
