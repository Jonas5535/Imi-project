using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAircraftTypeService : IAircraftTypeService
    {
        private readonly string _baseEndpoint;

        public ApiAircraftTypeService()
        {
            _baseEndpoint = "aircraftTypes";
        }

        public async Task<BaseResponse<AircraftType>> AddAsync(AircraftType entity)
        {
            BaseResponse<AircraftType> response = await WebApiClient.PostCallApi<AircraftType, AircraftType>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<AircraftType>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<AircraftType>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<AircraftType>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<AircraftType>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<ICollection<AircraftType>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<ICollection<AircraftType>>(_baseEndpoint);
        }

        public async Task<BaseResponse<AircraftType>> UpdateAsync(AircraftType entity)
        {
            return await WebApiClient.PutCallApi<AircraftType, AircraftType>(_baseEndpoint, entity);
        }
    }
}
