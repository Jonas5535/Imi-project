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
        private static ObservableCollection<Aircraft> _aircraftList;

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
