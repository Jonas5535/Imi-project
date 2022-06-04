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
            new Airline{ Id = Guid.Parse("cd8cf99b-d0c0-4de8-b708-46573523afe5"), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL"},
            new Airline{ Id = Guid.Parse("4e0b7e94-455c-485b-87d4-a357459a6ac1"), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF"},
            new Airline{ Id = Guid.Parse("0f1a0904-46f9-406a-afc2-460746623ad6"), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC"}
        };

        private static AircraftType[] _aircraftTypes = new AircraftType[]
        {
            new AircraftType{ Id = Guid.Parse("4673e611-2495-4e0c-97e4-4abff97ae018"), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320"},
            new AircraftType{ Id = Guid.Parse("a0979f14-e054-4928-a581-ddddd5aa2e89"), Brand = "Boeing", Type = "787-8", ICAOCode = "B788"},
            new AircraftType{ Id = Guid.Parse("e911ec3f-613e-443e-8756-50765d9ac40d"), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11"},
        };

        private static Airport[] _airports = new Airport[]
        {
            new Airport{ Id = Guid.Parse("41abe261-28a4-4d52-8da6-023ab750f21a"), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR"},
            new Airport{ Id = Guid.Parse("f6604525-b25b-4380-81f8-c65a80514ae1"), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN"},
            new Airport{ Id = Guid.Parse("fd41f824-25f5-41b2-be69-12ea56655f77"), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA"},
        };

        private static ICollection<Aircraft> _aircraftList = new List<Aircraft>
        {
            new Aircraft{ Id = Guid.Parse("41a6f6ff-696b-4b62-af8f-199d673aa4af"),Registration = "OO-SNJ", AircraftType = _aircraftTypes[0], Airline = _airlines[0],
                HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08), Image = "placeholder.png",
                Airports = new List<Airport>{ _airports[0], _airports[1], _airports[2] }
            },
            new Aircraft{ Id = Guid.Parse("5ee39ee4-9bd8-48c3-8506-264c022a6d79"), Registration = "OO-LOE", AircraftType = _aircraftTypes[1], Airline = _airlines[1],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08), Image = "placeholder.png",
                Airports = new List<Airport>{ _airports[0], _airports[1] }
            },
            new Aircraft{ Id = Guid.Parse("352608d3-8fe5-49b4-859c-1585ac0c30d0"), Registration = "D-ALCC", AircraftType = _aircraftTypes[2], Airline = _airlines[2],
                HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25), Image = "placeholder.png",
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
    }
}
