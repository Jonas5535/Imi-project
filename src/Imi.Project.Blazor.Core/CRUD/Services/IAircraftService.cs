using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface IAircraftService
    {
        Task<BaseResponse<IEnumerable<AircraftListViewModel>>> ListAllAsync();
        Task<BaseResponse<AircraftDetailViewModel>> GetByIdAsync(Guid id);
        Task<BaseResponse<AircraftListViewModel>> AddAsync(AircraftFormViewModel item);
        Task<BaseResponse<AircraftDetailViewModel>> UpdateAsync(AircraftFormViewModel item);
        Task<BaseResponse<AircraftListViewModel>> DeleteAsync(Guid id);
        Task<Airline[]> GetAirlines();
        Task<AircraftType[]> GetAircraftTypes();
        Task<Airport[]> GetAirports();
    }
}
