using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface ICRUDService<T>
    {
        Task<BaseResponse<ICollection<T>>> ListAllAsync();
        Task<BaseResponse<T>> GetByIdAsync(Guid id);
        Task<BaseResponse<T>> AddAsync(T entity);
        Task<BaseResponse<T>> UpdateAsync(T entity);
        Task<BaseResponse<T>> DeleteAsync(Guid id);

        //Only for MockAircraftService
        Task<Airline[]> GetAirlines();
        Task<AircraftType[]> GetAircraftTypes();
        Task<Airport[]> GetAirports();
    }
}
