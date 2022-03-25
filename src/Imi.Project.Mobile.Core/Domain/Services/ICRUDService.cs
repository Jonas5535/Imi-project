using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface ICRUDService<T>
    {
        Task<ICollection<T>> ListAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);

        //Only for MockAircraftService
        Task<Airline[]> GetAirlines();
        Task<AircraftType[]> GetAircraftTypes();
        Task<Airport[]> GetAirports();
    }
}
