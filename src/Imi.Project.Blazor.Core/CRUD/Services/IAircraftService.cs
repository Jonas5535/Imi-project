using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface IAircraftService
    {
        Task<IEnumerable<AircraftListViewModel>> ListAllAsync();
        Task<AircraftDetailViewModel> GetByIdAsync(Guid id);
        Task AddAsync(AircraftFormViewModel item);
        Task UpdateAsync(AircraftFormViewModel item);
        Task DeleteAsync(Guid id);
        Task<Airline[]> GetAirlines();
        Task<AircraftType[]> GetAircraftTypes();
        Task<Airport[]> GetAirports();
    }
}
