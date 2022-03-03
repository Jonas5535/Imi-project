using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAircraftTypeService
    {
        Task<IEnumerable<AircraftType>> GetAircraftTypes();
        Task<AircraftType> GetAircraftTypeById(Guid aircraftTypeId);
        Task<AircraftType> AddAircraftType(AircraftType aircraftType);
        Task<AircraftType> UpdateAircraftType(AircraftType aircraftType);
        Task<AircraftType> DeleteAircraftType(Guid aircraftTypeId);
    }
}
