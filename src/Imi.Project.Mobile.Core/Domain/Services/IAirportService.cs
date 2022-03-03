using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAirportService
    {
        Task<IEnumerable<Airport>> GetAirports();
        Task<Airport> GetAirportById(Guid airportId);
        Task<Airport> AddAirport(Airport airport);
        Task<Airport> UpdateAirport(Airport airport);
        Task<Airport> DeleteAirport(Guid airportId);
    }
}
