using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class MockAircraftService : ICRUDService<AircraftListViewModel, AircraftDetailViewModel, Aircraft>
    {
        private static Airline[] _airlines = new Airline[]
        {
            new Airline{ Id = Guid.Parse("fda5ebe2-57e1-4124-b63f-f5757768465d"), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL"},
            new Airline{ Id = Guid.Parse("33770603-1f1e-4663-ad2e-1235fe24c47d"), Name = "United Airlines", IATACode = "UA", ICAOCode = "UAL"},
            new Airline{ Id = Guid.Parse("2d03d2f7-ae21-4824-8a90-68cef74773ea"), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF"}
        };

        private static AircraftType[] _aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.Parse("3b8d2886-08c4-4330-ad1d-603d63c9bce7"), Brand = "Airbus", Type = "A319-100", ICAOCode = "A319"},
            new AircraftType{ Id = Guid.Parse("59edf443-9114-4a09-9858-75b98fe96e26"), Brand = "Boeing", Type = "787-10", ICAOCode = "B78X"},
            new AircraftType{ Id = Guid.Parse("df710544-7e48-40af-a9d5-b0a309b5ed39"), Brand = "Boeing", Type = "737-800", ICAOCode = "B738"},
        };

        private static Airport[] _airports = new Airport[]
        {
            new Airport{ Id = Guid.Parse("60f92c32-7c4d-4739-816b-7e014e98e03b"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR"},
            new Airport{ Id = Guid.Parse("f432e7f3-496c-4ac5-9b95-1be466cc995c"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN"},
            new Airport{ Id = Guid.Parse("a73f5cb3-8ca6-45d2-ab96-73e4ba98a6ab"), Name = "New York Newark Airport", IATACode = "EWR", ICAOCode = "KEWR"},
        };

        private static List<Aircraft> _aircrafts = new List<Aircraft>()
        {
            new Aircraft{ Id = Guid.NewGuid(), Registration = "OO-SSL", AircraftTypeId = _aircraftTypes[0].Id, AirlineId = _airlines[0].Id, HasSpecialLivery = false,
                FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2022, 02, 11),
                AirportIds = new List<Guid>{ _airports[0].Id, _airports[1].Id, _airports[2].Id }, Image = "/Images/CRUD/IMG_1974.JPG" },
            new Aircraft{ Id = Guid.NewGuid(), Registration = "N12003", AircraftTypeId = _aircraftTypes[1].Id, AirlineId = _airlines[1].Id, HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2022, 02, 11),
                AirportIds = new List<Guid>{ _airports[0].Id, _airports[2].Id }, Image = "/Images/CRUD/IMG_1935.JPG"},
            new Aircraft{ Id = Guid.NewGuid(), Registration = "OO-TNB", AircraftTypeId = _aircraftTypes[2].Id, AirlineId = _airlines[2].Id, HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2022, 02, 11),
                AirportIds = new List<Guid>{ _airports[1].Id }, Image = "/Images/CRUD/IMG_1891.JPG"},
        };

        public Task AddAsync(Aircraft item)
        {
            _aircrafts.Add(item);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            Aircraft aircraft = _aircrafts.SingleOrDefault(a => a.Id == id);
            if (aircraft == null) throw new ArgumentException("aircraft not found");
            _aircrafts.Remove(aircraft);
            return Task.CompletedTask;
        }

        public async Task<AircraftDetailViewModel> GetByIdAsync(Guid id)
        {
            Aircraft aircraft = _aircrafts.SingleOrDefault(a => a.Id == id);
            if (aircraft == null) throw new ArgumentException("aircraft not found");

            AircraftDetailViewModel result;

            result = new AircraftDetailViewModel
            {
                Id = aircraft.Id,
                Registration = aircraft.Registration,
                HasSpecialLivery = aircraft.HasSpecialLivery,
                FirstSeen = aircraft.FirstSeen,
                LastSeen = aircraft.LastSeen,
                Image = aircraft.Image,
                AircraftType = _aircraftTypes.FirstOrDefault(a => a.Id == aircraft.AircraftTypeId),
                Airline = _airlines.FirstOrDefault(a => a.Id == aircraft.AirlineId),
            };
            
            result.Airports = new List<Airport>();

            foreach (var airportId in aircraft.AirportIds)
            {
                Airport airport = _airports.FirstOrDefault(a => a.Id.Equals(airportId));
                result.Airports.Add(airport);
            }

            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<AircraftListViewModel>> ListAllAsync()
        {
            List<AircraftListViewModel> aircrafts;

            aircrafts = _aircrafts.Select(a => new AircraftListViewModel()
            {
                Id = a.Id,
                Registration = a.Registration,
                Image = a.Image,
                AircraftType = _aircraftTypes.FirstOrDefault(at => at.Id.Equals(a.AircraftTypeId)),
                Airline = _airlines.FirstOrDefault(al => al.Id.Equals(a.AirlineId)),
            }).ToList();

            return await Task.FromResult(aircrafts);
        }

        public Task UpdateAsync(Aircraft item)
        {
            throw new NotImplementedException();
        }
    }
}
