using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftService : IAircraftService
    {
        private static ObservableCollection<Aircraft> _aircraftList = new ObservableCollection<Aircraft>
        {
            new Aircraft{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),Registration = "OO-SNJ", AircraftType = "A320", Airline = "Brussels Airlines", HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08),
                Airports = new ObservableCollection<string>{ "Brussels Airport", "Nice Côte d'Azur", "Tokyo Narita Intl. Airport"}
            },
            new Aircraft{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Registration = "OO-LOE", AircraftType = "B788", Airline = "TUI Fly", HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<string>{ "Brussels Airport", "Nice Côte d'Azur" }
            },
            new Aircraft{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Registration = "D-ALCC", AircraftType = "MD11", Airline = "Lufthansa Cargo", HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25),
                Airports = new List<string>{ "Tokyo Narita Intl. Airport" }
            }
        };

        public async Task<Aircraft> AddAircraft(Aircraft aircraft)
        {
            _aircraftList.Add(aircraft);
            return await Task.FromResult(aircraft);
        }

        public async Task<Aircraft> DeleteAircraft(Guid aircraftId)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == aircraftId);
            _aircraftList.Remove(aircraft);
            return await Task.FromResult(aircraft);
        }

        public async Task<Aircraft> GetAircraftById(Guid aircraftId)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == aircraftId);
            return await Task.FromResult(aircraft);
        }

        public async Task<IEnumerable<Aircraft>> GetAircrafts()
        {
            IEnumerable<Aircraft> aircrafts = _aircraftList;
            return await Task.FromResult(aircrafts);
        }

        public async Task<Aircraft> UpdateAircraft(Aircraft aircraft)
        {
            Aircraft EditedAircraft = _aircraftList.FirstOrDefault(a => a.Id == aircraft.Id);
            _aircraftList.Remove(EditedAircraft);
            _aircraftList.Add(EditedAircraft);
            return await Task.FromResult(EditedAircraft);
        }
    }
}
