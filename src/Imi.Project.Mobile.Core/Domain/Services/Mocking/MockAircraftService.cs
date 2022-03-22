using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftService : ICRUDService<Aircraft>
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;
        private readonly ICRUDService<Airline> _airlineService;
        private readonly ICRUDService<Airport> _airportService;

        public MockAircraftService(ICRUDService<AircraftType> aircraftService, ICRUDService<Airline> airlineService, ICRUDService<Airport> airportService)
        {
            _aircraftTypeService = aircraftService;
            _airlineService = airlineService;
            _airportService = airportService;
        }

        private static Airline[] airlines = new Airline[]
        {
            new Airline{ Id = Guid.Parse("fda5ebe2-57e1-4124-b63f-f5757768465d"), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL"},
            new Airline{ Id = Guid.Parse("33770603-1f1e-4663-ad2e-1235fe24c47d"), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF"},
            new Airline{ Id = Guid.Parse("2d03d2f7-ae21-4824-8a90-68cef74773ea"), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC"}
        };

        private static AircraftType[] aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.Parse("3b8d2886-08c4-4330-ad1d-603d63c9bce7"), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320"},
            new AircraftType{ Id = Guid.Parse("59edf443-9114-4a09-9858-75b98fe96e26"), Brand = "Boeing", Type = "787-8", ICAOCode = "B788"},
            new AircraftType{ Id = Guid.Parse("df710544-7e48-40af-a9d5-b0a309b5ed39"), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11"},
        };

        private static Airport[] airports = new Airport[]
        {
            new Airport{ Id = Guid.Parse("60f92c32-7c4d-4739-816b-7e014e98e03b"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR"},
            new Airport{ Id = Guid.Parse("f432e7f3-496c-4ac5-9b95-1be466cc995c"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN"},
            new Airport{ Id = Guid.Parse("a73f5cb3-8ca6-45d2-ab96-73e4ba98a6ab"), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA"},
        };

        private static ICollection<Aircraft> _aircraftList = new List<Aircraft>
        {
            new Aircraft{ Id = Guid.Parse("41a6f6ff-696b-4b62-af8f-199d673aa4af"),Registration = "OO-SNJ", AircraftType = aircraftTypes[0], Airline = airlines[0], 
                HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<Airport>{ airports[0], airports[1], airports[2]}
            },
            new Aircraft{ Id = Guid.Parse("5ee39ee4-9bd8-48c3-8506-264c022a6d79"), Registration = "OO-LOE", AircraftType = aircraftTypes[1], Airline = airlines[1],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<Airport>{ airports[0], airports[1] }
            },
            new Aircraft{ Id = Guid.Parse("352608d3-8fe5-49b4-859c-1585ac0c30d0"), Registration = "D-ALCC", AircraftType = aircraftTypes[2], Airline = airlines[2],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25),
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

        public async Task<ICollection<Aircraft>> ListAllAsync()
        {
            IEnumerable<Aircraft> aircraftList = _aircraftList;

            // Replace the coupled aircrafttype that was defined in this class to the same one that was defined in the MockAircraftTypeService
            // This is needed to make sure the picker recognizes the aircraftType
            // Idem for airline and airport
            ICollection<Aircraft> aircrafts = await ReplaceType(aircraftList);
            aircrafts = await ReplaceAirline(aircrafts);
            aircrafts = await ReplaceAirport(aircrafts);

            return await Task.FromResult(aircrafts);
        }

        public async Task<Aircraft> UpdateAsync(Aircraft entity)
        {
            Aircraft EditedAircraft = _aircraftList.FirstOrDefault(a => a.Id == entity.Id);
            _aircraftList.Remove(EditedAircraft);
            _aircraftList.Add(EditedAircraft);
            return await Task.FromResult(EditedAircraft);
        }

        private async Task<ICollection<Aircraft>> ReplaceType(IEnumerable<Aircraft> aircraftList)
        {
            IEnumerable<AircraftType> types = await _aircraftTypeService.ListAllAsync();
            ICollection<Aircraft> aircrafts = new List<Aircraft>();

            foreach (var aircraft in aircraftList)
            {
                AircraftType type = types.Where(a => a.ICAOCode == aircraft.AircraftType.ICAOCode).FirstOrDefault();
                aircraft.AircraftType = type;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }

        private async Task<ICollection<Aircraft>> ReplaceAirline(ICollection<Aircraft> aircraftList)
        {
            IEnumerable<Airline> airlines = await _airlineService.ListAllAsync();
            ICollection<Aircraft> aircrafts = new List<Aircraft>();

            foreach (var aircraft in aircraftList)
            {
                Airline airline = airlines.Where(a => a.ICAOCode == aircraft.Airline.ICAOCode).FirstOrDefault();
                aircraft.Airline = airline;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }

        private async Task<ICollection<Aircraft>> ReplaceAirport(ICollection<Aircraft> aircraftList)
        {
            IEnumerable<Airport> airports = await _airportService.ListAllAsync();
            ICollection<Aircraft> aircrafts = new List<Aircraft>();

            foreach (var aircraft in aircraftList)
            {
                var newAirportList = new List<Airport>();
                foreach (var airport in aircraft.Airports)
                {
                    Airport airportFromService = airports.Where(a => a.ICAOCode == airport.ICAOCode).FirstOrDefault();
                    newAirportList.Add(airportFromService);
                }
                aircraft.Airports = newAirportList;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }
    }
}
