using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirlineService : IAirlineService
    {
        private static ObservableCollection<Airline> _airlineList;

        public async Task<Airline> AddAirline(Airline airline)
        {
            _airlineList.Add(airline);
            return await Task.FromResult(airline);
        }

        public async Task<Airline> DeleteAirline(Guid airlineId)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == airlineId);
            _airlineList.Remove(airline);
            return await Task.FromResult(airline);
        }

        public async Task<Airline> GetAirlineById(Guid airlineId)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == airlineId);
            return await Task.FromResult(airline);
        }

        public async Task<IEnumerable<Airline>> GetAirlines()
        {
            IEnumerable<Airline> airlines = _airlineList;
            return await Task.FromResult(airlines);
        }

        public async Task<Airline> UpdateAirline(Airline airline)
        {
            Airline EditedAirline = _airlineList.FirstOrDefault(a => a.Id == airline.Id);
            _airlineList.Remove(EditedAirline);
            _airlineList.Add(EditedAirline);
            return await Task.FromResult(EditedAirline);
        }
    }
}
