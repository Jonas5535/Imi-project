using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftService : ICRUDService<Aircraft>
    {
        private static Airline[] airlines = new Airline[]
        {
            new Airline{ Id = Guid.NewGuid(), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL"},
            new Airline{ Id = Guid.NewGuid(), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF"},
            new Airline{ Id = Guid.NewGuid(), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC"}
        };

        private static AircraftType[] aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320"},
            new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "787-8", ICAOCode = "B788"},
            new AircraftType{ Id = Guid.NewGuid(), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11"},
        };

        private static Airport[] airports = new Airport[]
        {
            new Airport{ Id = Guid.NewGuid(), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR"},
            new Airport{ Id = Guid.NewGuid(), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN"},
            new Airport{ Id = Guid.NewGuid(), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA"},
        };

        private static ObservableCollection<Aircraft> _aircraftList = new ObservableCollection<Aircraft>
        {
            new Aircraft{ Id = Guid.NewGuid(),Registration = "OO-SNJ", AircraftType = aircraftTypes[0], Airline = airlines[0], HasSpecialLivery = false,
                FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08),
                Airports = new ObservableCollection<Airport>{ airports[0], airports[1], airports[2]}
            },
            new Aircraft{ Id = Guid.NewGuid(), Registration = "OO-LOE", AircraftType = aircraftTypes[1], Airline = airlines[1], HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<Airport>{ airports[0], airports[1] }
            },
            new Aircraft{ Id = Guid.NewGuid(), Registration = "D-ALCC", AircraftType = aircraftTypes[2], Airline = airlines[2], HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25),
                Airports = new List<Airport>{ airports[2] }
            }
        };

        public async Task<Aircraft> AddAsync(Aircraft entity)
        {
            _aircraftList.Add(entity);
            return await Task.FromResult(entity);
        }

        public async Task<Aircraft> DeleteAsync(Guid id)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == id);
            _aircraftList.Remove(aircraft);
            return await Task.FromResult(aircraft);
        }

        public async Task<Aircraft> GetByIdAsync(Guid id)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == id);
            return await Task.FromResult(aircraft);
        }

        public async Task<ObservableCollection<Aircraft>> ListAllAsync()
        {
            ObservableCollection<Aircraft> aircrafts = _aircraftList;
            return await Task.FromResult(aircrafts);
        }

        public async Task<Aircraft> UpdateAsync(Aircraft entity)
        {
            Aircraft EditedAircraft = _aircraftList.FirstOrDefault(a => a.Id == entity.Id);
            _aircraftList.Remove(EditedAircraft);
            _aircraftList.Add(EditedAircraft);
            return await Task.FromResult(EditedAircraft);
        }
    }
}
