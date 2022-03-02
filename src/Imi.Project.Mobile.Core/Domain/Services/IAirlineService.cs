using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAirlineService
    {
        Task<IEnumerable<Airline>> GetAirlines();
        Task<Airline> GetAirlineById(Guid airlineId);
        Task<Airline> AddAirline(Airline airline);
        Task<Airline> UpdateAirline(Airline airline);
        Task<Airline> DeleteAirline(Guid airlineId);
    }
}
