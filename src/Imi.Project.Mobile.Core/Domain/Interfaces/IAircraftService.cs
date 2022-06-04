using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Interfaces
{
    public interface IAircraftService
    {
        Task<BaseResponse<ICollection<Aircraft>>> ListAllAsync();
        Task<BaseResponse<Aircraft>> GetByIdAsync(Guid id);
        Task<BaseResponse<Aircraft>> AddAsync(AircraftFormModel entity);
        Task<BaseResponse<Aircraft>> UpdateAsync(AircraftFormModel entity);
        Task<BaseResponse<Aircraft>> DeleteAsync(Guid id);
    }
}
