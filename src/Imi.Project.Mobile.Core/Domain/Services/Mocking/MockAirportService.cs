using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirportService : IAirportService
    {
        private static ObservableCollection<Airport> _airportList = new ObservableCollection<Airport>();

        public async Task<Airport> AddAirport(Airport airport)
        {
            _airportList.Add(airport);
            return await Task.FromResult(airport);
        }

        public async Task<Airport> DeleteAirport(Guid airportId)
        {
            Airport airport = _airportList.FirstOrDefault(a => a.Id == airportId);
            _airportList.Remove(airport);
            return await Task.FromResult(airport);
        }

        public async Task<Airport> GetAirportById(Guid airportId)
        {
            Airport airport = _airportList.FirstOrDefault(a => a.Id == airportId);
            return await Task.FromResult(airport);
        }

        public async Task<IEnumerable<Airport>> GetAirports()
        {
            IEnumerable<Airport> airports = _airportList;
            return await Task.FromResult(airports);
        }

        public async Task<Airport> UpdateAirport(Airport airport)
        {
            Airport EditedAirport = _airportList.FirstOrDefault(a => a.Id == airport.Id);
            _airportList.Remove(EditedAirport);
            _airportList.Add(EditedAirport);
            return await Task.FromResult(EditedAirport);
        }
    }
}
