using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAircraftService : IAircraftService
    {
        private readonly string _baseEndpoint;

        public ApiAircraftService()
        {
            _baseEndpoint = "aircrafts";
        }

        public Task<BaseResponse<Aircraft>> AddAsync(AircraftFormModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<Aircraft>> DeleteAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<Aircraft>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<AircraftType[]>> GetAircraftTypes()
        {
            return await WebApiClient.GetApiResult<AircraftType[]>("aircraftTypes");
        }

        public async Task<BaseResponse<Airline[]>> GetAirlines()
        {
            return await WebApiClient.GetApiResult<Airline[]>("airlines");
        }

        public async Task<BaseResponse<Airport[]>> GetAirports()
        {
            return await WebApiClient.GetApiResult<Airport[]>("airports");
        }

        public async Task<BaseResponse<Aircraft>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<Aircraft>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<ICollection<Aircraft>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<ICollection<Aircraft>>(_baseEndpoint);
        }

        public Task<BaseResponse<Aircraft>> UpdateAsync(AircraftFormModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
