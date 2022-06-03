using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Interfaces
{
    public interface IAirportService
    {
        Task<BaseResponse<ICollection<Airport>>> ListAllAsync();
        Task<BaseResponse<Airport>> GetByIdAsync(Guid id);
        Task<BaseResponse<Airport>> AddAsync(Airport entity);
        Task<BaseResponse<Airport>> UpdateAsync(Airport entity);
        Task<BaseResponse<Airport>> DeleteAsync(Guid id);
    }
}
