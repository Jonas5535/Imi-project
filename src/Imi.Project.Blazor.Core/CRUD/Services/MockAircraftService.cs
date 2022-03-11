using Imi.Project.Blazor.Core.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class MockAircraftService : ICRUDService<AircraftListItem, AircraftItem>
    {
        private static InputSelectItem[] _aircraftTypes = new InputSelectItem[]
        {
            new InputSelectItem() { Value = "1", Label = "A319"},
            new InputSelectItem() { Value = "2", Label = "B78X"},
            new InputSelectItem() { Value = "3", Label = "B738"}
        };

        private static InputSelectItem[] _airlines = new InputSelectItem[]
        {
            new InputSelectItem(){ Value = "1", Label = "Brussels Airlines"},
            new InputSelectItem(){ Value = "2", Label = "United Airlines"},
            new InputSelectItem(){ Value = "3", Label = "TUI Fly"}
        };

        private static InputSelectItem[] _airports = new InputSelectItem[]
        {
            new InputSelectItem{ Value = "1", Label = "Brussels Airport"},
            new InputSelectItem{ Value = "2", Label = "Nice Côte d'Azur"},
            new InputSelectItem{ Value = "3", Label = "New York Newark Airport"},
        };

        private static List<AircraftItem> _aircrafts = new List<AircraftItem>()
        {
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "OO-SSL", AircraftTypeId = "1", AirlineId = "1", HasSpecialLivery = false,
                FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2022, 02, 11), AirportIds = new List<string>{ "1", "2", "3" },
                Image = "/Images/CRUD/IMG_1974.JPG" },
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "N12003", AircraftTypeId = "2", AirlineId = "2", HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2022, 02, 11), AirportIds = new List<string>{ "1", "3" },
            Image = "/Images/CRUD/IMG_1935.JPG"},
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "OO-TNB", AircraftTypeId = "3", AirlineId = "3", HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2022, 02, 11), AirportIds = new List<string>{ "2", },
            Image = "/Images/CRUD/IMG_1891.JPG"},
        };

        public Task AddAsync(AircraftItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AircraftItem> GetByIdAsync(Guid id)
        {
            AircraftItem aircraft = _aircrafts.SingleOrDefault(a => a.Id == id);
            aircraft.AircraftTypes = _aircraftTypes;
            aircraft.Airlines = _airlines;
            aircraft.Airports = _airports;

            return await Task.FromResult(aircraft);
        }

        public async Task<IEnumerable<AircraftListItem>> ListAllAsync()
        {
            List<AircraftListItem> aircrafts;

            aircrafts = _aircrafts.Select(a => new AircraftListItem()
            {
                Id = a.Id,
                Registration = a.Registration,
                Image = a.Image,
                AircraftType = _aircraftTypes
                    .Where(at => at.Value == a.AircraftTypeId)
                    .Select(at => at.Label)
                    .SingleOrDefault(),
                Airline = _airlines
                    .Where(al => al.Value == a.AirlineId)
                    .Select(al => al.Label)
                    .SingleOrDefault()
            }).ToList();

            return await Task.FromResult(aircrafts);
        }

        public Task UpdateAsync(AircraftItem item)
        {
            throw new NotImplementedException();
        }
    }
}
