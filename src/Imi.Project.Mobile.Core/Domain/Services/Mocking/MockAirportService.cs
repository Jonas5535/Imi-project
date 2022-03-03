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
        private static ObservableCollection<Airport> _airportList = new ObservableCollection<Airport>
        {
            new Airport{Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR", ElevationAMSL = 56, RunwayAmount = 3, TerminalAmount = 1, Country = "België", City = "Zaventem" },
            new Airport{Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN", ElevationAMSL = 4, RunwayAmount = 2, TerminalAmount = 3, Country = "Frankrijk", City = "Nice" },
            new Airport{Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA", ElevationAMSL = 41, RunwayAmount = 2, TerminalAmount = 3, Country = "japan", City = "Narita" }
        };

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
