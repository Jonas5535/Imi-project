using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAirportService : ICRUDService<Airport>
    {
        private readonly string _baseEndpoint;

        public ApiAirportService()
        {
            _baseEndpoint = "airports";
        }

        public async Task<BaseResponse<Airport>> AddAsync(Airport entity)
        {
            BaseResponse<Airport> response = await WebApiClient.PostCallApi<BaseResponse<Airport>, Airport>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<Airport>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<BaseResponse<Airport>>($"{_baseEndpoint}/{id}");
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
            return await WebApiClient.PutCallApi<BaseResponse<Airport>, Airport>(_baseEndpoint, entity);
        }
    }
}
