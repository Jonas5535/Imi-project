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

        // Id of airlines, airports and aircraft types are the same as their counterparts in their respective services
        // This is needed to exchange the objects defined here to their counterparts from the their respective services
        private static Airline[] airlines = new Airline[]
        {
            new Airline{ Id = Guid.Parse("cd8cf99b-d0c0-4de8-b708-46573523afe5") },
            new Airline{ Id = Guid.Parse("4e0b7e94-455c-485b-87d4-a357459a6ac1") },
            new Airline{ Id = Guid.Parse("0f1a0904-46f9-406a-afc2-460746623ad6") }
        };

        private static AircraftType[] aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.Parse("4673e611-2495-4e0c-97e4-4abff97ae018") },
            new AircraftType{ Id = Guid.Parse("a0979f14-e054-4928-a581-ddddd5aa2e89") },
            new AircraftType{ Id = Guid.Parse("e911ec3f-613e-443e-8756-50765d9ac40d") },
        };

        private static Airport[] airports = new Airport[]
        {
            new Airport{ Id = Guid.Parse("41abe261-28a4-4d52-8da6-023ab750f21a") },
            new Airport{ Id = Guid.Parse("f6604525-b25b-4380-81f8-c65a80514ae1") },
            new Airport{ Id = Guid.Parse("fd41f824-25f5-41b2-be69-12ea56655f77") },
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
                AircraftType type = types.Where(a => a.Id == aircraft.AircraftType.Id).FirstOrDefault();
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
                Airline airline = airlines.Where(a => a.Id == aircraft.Airline.Id).FirstOrDefault();
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
                    Airport airportFromService = airports.Where(a => a.Id == airport.Id).FirstOrDefault();
                    newAirportList.Add(airportFromService);
                }
                aircraft.Airports = newAirportList;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }
    }
}
