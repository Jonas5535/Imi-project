using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class ApiAircraftService : IAircraftService
    {
        private readonly string _baseEndpoint;

        public ApiAircraftService()
        {
            _baseEndpoint = "aircrafts";
        }

        public Task<BaseResponse<AircraftListViewModel>> AddAsync(AircraftFormViewModel item)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AircraftListViewModel>> DeleteAsync(Guid id)
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

        public Task<BaseResponse<AircraftDetailViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<AircraftListViewModel>>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AircraftDetailViewModel>> UpdateAsync(AircraftFormViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
