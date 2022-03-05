using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirportService : ICRUDService<Airport>
    {
        private static ObservableCollection<Airport> _airportList = new ObservableCollection<Airport>
        {
            new Airport{Id = Guid.NewGuid(), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR", ElevationAMSL = 56, RunwayAmount = 3,
                TerminalAmount = 1, Country = "België", City = "Zaventem" },
            new Airport{Id = Guid.NewGuid(), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN", ElevationAMSL = 4, RunwayAmount = 2,
                TerminalAmount = 3, Country = "Frankrijk", City = "Nice" },
            new Airport{Id = Guid.NewGuid(), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA", ElevationAMSL = 41, RunwayAmount = 2,
                TerminalAmount = 3, Country = "japan", City = "Narita" }
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

        public async Task<Airport> GetByIdAsync(Guid id)
        {
            Airport airport = _airportList.FirstOrDefault(a => a.Id == id);
            return await Task.FromResult(airport);
        }

        public async Task<IEnumerable<Airport>> ListAllAsync()
        {
            IEnumerable<Airport> airports = _airportList;
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
