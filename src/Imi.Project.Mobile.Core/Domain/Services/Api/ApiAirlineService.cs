using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAirlineService : ICRUDService<Airline>
    {
        private readonly string _baseEndpoint;

        public ApiAirlineService()
        {
            _baseEndpoint = $"https://192.168.50.100:5001/api/airlines";
        }

        public Task<BaseResponse<Airline>> AddAsync(Airline entity)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Airline>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
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

        public Task<BaseResponse<Airline>> UpdateAsync(Airline entity)
        {
            throw new NotImplementedException();
        }
    }
}
