using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Interfaces
{
    public interface IAirlineService
    {
        Task<BaseResponse<ICollection<Airline>>> ListAllAsync();
        Task<BaseResponse<Airline>> GetByIdAsync(Guid id);
        Task<BaseResponse<Airline>> AddAsync(Airline entity);
        Task<BaseResponse<Airline>> UpdateAsync(Airline entity);
        Task<BaseResponse<Airline>> DeleteAsync(Guid id);
    }
}
