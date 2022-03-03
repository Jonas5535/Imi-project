using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAircraftService
    {
        Task<IEnumerable<Aircraft>> GetAircrafts();
        Task<Aircraft> GetAircraftById(Guid aircraftId);
        Task<Aircraft> AddAircraft(Aircraft aircraft);
        Task<Aircraft> UpdateAircraft(Aircraft aircraft);
        Task<Aircraft> DeleteAircraft(Guid aircraftId);
    }
}
