using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftService : IAircraftService
    {
        private static Airline[] _airlines = new Airline[]
        {
            new Airline{ Id = Guid.Parse("fda5ebe2-57e1-4124-b63f-f5757768465d"), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL"},
            new Airline{ Id = Guid.Parse("33770603-1f1e-4663-ad2e-1235fe24c47d"), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF"},
            new Airline{ Id = Guid.Parse("2d03d2f7-ae21-4824-8a90-68cef74773ea"), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC"}
        };

        private static AircraftType[] _aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.Parse("3b8d2886-08c4-4330-ad1d-603d63c9bce7"), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320"},
            new AircraftType{ Id = Guid.Parse("59edf443-9114-4a09-9858-75b98fe96e26"), Brand = "Boeing", Type = "787-8", ICAOCode = "B788"},
            new AircraftType{ Id = Guid.Parse("df710544-7e48-40af-a9d5-b0a309b5ed39"), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11"},
        };

        private static Airport[] _airports = new Airport[]
        {
            new Airport{ Id = Guid.Parse("60f92c32-7c4d-4739-816b-7e014e98e03b"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR"},
            new Airport{ Id = Guid.Parse("f432e7f3-496c-4ac5-9b95-1be466cc995c"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN"},
            new Airport{ Id = Guid.Parse("a73f5cb3-8ca6-45d2-ab96-73e4ba98a6ab"), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA"},
        };

        private static ICollection<Aircraft> _aircraftList = new List<Aircraft>
        {
            new Aircraft{ Id = Guid.Parse("41a6f6ff-696b-4b62-af8f-199d673aa4af"),Registration = "OO-SNJ", AircraftType = _aircraftTypes[0], Airline = _airlines[0],
                HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<Airport>{ _airports[0], _airports[1], _airports[2]}
            },
            new Aircraft{ Id = Guid.Parse("5ee39ee4-9bd8-48c3-8506-264c022a6d79"), Registration = "OO-LOE", AircraftType = _aircraftTypes[1], Airline = _airlines[1],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08),
                Airports = new List<Airport>{ _airports[0], _airports[1] }
            },
            new Aircraft{ Id = Guid.Parse("352608d3-8fe5-49b4-859c-1585ac0c30d0"), Registration = "D-ALCC", AircraftType = _aircraftTypes[2], Airline = _airlines[2],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25),
                Airports = new List<Airport>{ _airports[2] }
            }
        };

        public async Task<BaseResponse<Aircraft>> AddAsync(AircraftFormModel entity)
        {
            Aircraft aircraft = new Aircraft
            {
                Id = entity.Id,
                Registration = entity.Registration,
                HasSpecialLivery = entity.HasSpecialLivery,
                FirstSeen = entity.FirstSeen,
                LastSeen = entity.LastSeen,
                AircraftType = _aircraftTypes.FirstOrDefault(a => a.Id.Equals(entity.AircraftTypeId)),
                Airline = _airlines.FirstOrDefault(a => a.Id.Equals(entity.AirlineId)),
                Airports = new List<Airport>()
            };

            foreach (var airportId in entity.AirportIds)
            {
                Airport airport = _airports.FirstOrDefault(a => a.Id.Equals(airportId));
                aircraft.Airports.Add(airport);
            }

            _aircraftList.Add(aircraft);
            BaseResponse<Aircraft> response = new BaseResponse<Aircraft>();
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<Aircraft>> DeleteAsync(Guid id)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == id);
            _aircraftList.Remove(aircraft);

            BaseResponse<Aircraft> response = new BaseResponse<Aircraft>();
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<Aircraft>> GetByIdAsync(Guid id)
        {
            Aircraft aircraft = _aircraftList.FirstOrDefault(a => a.Id == id);
            BaseResponse<Aircraft> response = new BaseResponse<Aircraft> { Data = aircraft };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<ICollection<Aircraft>>> ListAllAsync()
        {
            ICollection<Aircraft> aircrafts = _aircraftList;
            BaseResponse<ICollection<Aircraft>> response = new BaseResponse<ICollection<Aircraft>> { Data = aircrafts };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<Aircraft>> UpdateAsync(AircraftFormModel entity)
        {
            Aircraft EditedAircraft = _aircraftList.FirstOrDefault(a => a.Id == entity.Id);

            EditedAircraft.Registration = entity.Registration;
            EditedAircraft.HasSpecialLivery = entity.HasSpecialLivery;
            EditedAircraft.FirstSeen = entity.FirstSeen;
            EditedAircraft.LastSeen = entity.LastSeen;
            EditedAircraft.AircraftType = _aircraftTypes.FirstOrDefault(a => a.Id.Equals(entity.AircraftTypeId));
            EditedAircraft.Airline = _airlines.FirstOrDefault(a => a.Id.Equals(entity.AirlineId));

            BaseResponse<Aircraft> response = new BaseResponse<Aircraft>();
            return await Task.FromResult(response);
        }

        public async Task<Airline[]> GetAirlines()
        {
            return await Task.FromResult(_airlines);
        }

        public async Task<AircraftType[]> GetAircraftTypes()
        {
            return await Task.FromResult(_aircraftTypes);
        }

        public async Task<Airport[]> GetAirports()
        {
            return await Task.FromResult(_airports);
        }
    }
}
