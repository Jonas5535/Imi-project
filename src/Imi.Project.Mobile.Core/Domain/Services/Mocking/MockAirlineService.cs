using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirlineService : ICRUDService<Airline>
    {
        private static ObservableCollection<Airline> _airlineList = new ObservableCollection<Airline>
        {
            new Airline{ Id = Guid.NewGuid(), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL", MainAirport = "Brussels Airport",
                HeadQuarter = "Diegem, België", FleetSize = 49 },
            new Airline{ Id = Guid.NewGuid(), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF", MainAirport = "Brussels Airport",
                HeadQuarter = "Zaventem, België", FleetSize = 32 },
            new Airline{ Id = Guid.NewGuid(), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC", MainAirport = "Frankfurt am Main",
                HeadQuarter = "Frankfurt, Duitsland", FleetSize = 18 }
        };

        public async Task<Airline> AddAsync(Airline entity)
        {
            _airlineList.Add(entity);
            return await Task.FromResult(entity);
        }

        public async Task<Airline> DeleteAsync(Guid id)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == id);
            _airlineList.Remove(airline);
            return await Task.FromResult(airline);
        }

        public async Task<Airline> GetByIdAsync(Guid id)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == id);
            return await Task.FromResult(airline);
        }

        public async Task<ObservableCollection<Airline>> ListAllAsync()
        {
            ObservableCollection<Airline> airlines = _airlineList;
            return await Task.FromResult(airlines);
        }

        public async Task<Airline> UpdateAsync(Airline entity)
        {
            Airline EditedAirline = _airlineList.FirstOrDefault(a => a.Id == entity.Id);
            _airlineList.Remove(EditedAirline);
            _airlineList.Add(EditedAirline);
            return await Task.FromResult(EditedAirline);
        }
    }
}
