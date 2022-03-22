using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirportService : ICRUDService<Airport>
    {
        private static ICollection<Airport> _airportList = new List<Airport>
        {
            new Airport{Id = Guid.Parse("41abe261-28a4-4d52-8da6-023ab750f21a"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR",
                ElevationAMSL = 56, RunwayAmount = 3, TerminalAmount = 1, Country = "België", City = "Zaventem" },
            new Airport{Id = Guid.Parse("f6604525-b25b-4380-81f8-c65a80514ae1"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN",
                ElevationAMSL = 4, RunwayAmount = 2, TerminalAmount = 3, Country = "Frankrijk", City = "Nice" },
            new Airport{Id = Guid.Parse("fd41f824-25f5-41b2-be69-12ea56655f77"), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA",
                ElevationAMSL = 41, RunwayAmount = 2, TerminalAmount = 3, Country = "japan", City = "Narita" }
        };

        public async Task<Airport> AddAsync(Airport entity)
        {
            _airportList.Add(entity);
            return await Task.FromResult(entity);
        }

        public async Task<Airport> DeleteAsync(Guid id)
        {
            Airport airport = _airportList.FirstOrDefault(a => a.Id == id);
            _airportList.Remove(airport);
            return await Task.FromResult(airport);
        }

        public Task<AircraftType[]> GetAircraftTypes()
        {
            throw new NotImplementedException();
        }

        public Task<Airline[]> GetAirlines()
        {
            throw new NotImplementedException();
        }

        public Task<Airport[]> GetAirports()
        {
            throw new NotImplementedException();
        }

        public async Task<Airport> GetByIdAsync(Guid id)
        {
            Airport airport = _airportList.FirstOrDefault(a => a.Id == id);
            return await Task.FromResult(airport);
        }

        public async Task<ICollection<Airport>> ListAllAsync()
        {
            ICollection<Airport> airports = _airportList;
            return await Task.FromResult(airports);
        }

        public async Task<Airport> UpdateAsync(Airport entity)
        {
            Airport EditedAirport = _airportList.FirstOrDefault(a => a.Id == entity.Id);
            _airportList.Remove(EditedAirport);
            _airportList.Add(EditedAirport);
            return await Task.FromResult(EditedAirport);
        }
    }
}
