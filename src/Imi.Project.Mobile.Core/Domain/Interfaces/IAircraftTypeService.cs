using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Interfaces
{
    public interface IAircraftTypeService
    {
        Task<BaseResponse<ICollection<AircraftType>>> ListAllAsync();
        Task<BaseResponse<AircraftType>> GetByIdAsync(Guid id);
        Task<BaseResponse<AircraftType>> AddAsync(AircraftType entity);
        Task<BaseResponse<AircraftType>> UpdateAsync(AircraftType entity);
        Task<BaseResponse<AircraftType>> DeleteAsync(Guid id);
    }
}
