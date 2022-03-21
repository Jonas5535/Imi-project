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
            ObservableCollection<Aircraft> aircraftList = _aircraftList;

            // Replace the coupled aircrafttype that was defined in this class to the same one that was defined in the MockAircraftTypeService
            // This is needed to make sure the picker recognizes the aircraftType
            // Idem for airline and airport
            ObservableCollection<Aircraft> aircrafts = await ReplaceType(aircraftList);
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

        private async Task<ObservableCollection<Aircraft>> ReplaceType(ObservableCollection<Aircraft> aircraftList)
        {
            ObservableCollection<AircraftType> types = await _aircraftTypeService.ListAllAsync();
            ObservableCollection<Aircraft> aircrafts = new ObservableCollection<Aircraft>();

            foreach (var aircraft in aircraftList)
            {
                AircraftType type = types.Where(a => a.ICAOCode == aircraft.AircraftType.ICAOCode).FirstOrDefault();
                aircraft.AircraftType = type;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }

        private async Task<ObservableCollection<Aircraft>> ReplaceAirline(ObservableCollection<Aircraft> aircraftList)
        {
            ObservableCollection<Airline> airlines = await _airlineService.ListAllAsync();
            ObservableCollection<Aircraft> aircrafts = new ObservableCollection<Aircraft>();

            foreach (var aircraft in aircraftList)
            {
                Airline airline = airlines.Where(a => a.ICAOCode == aircraft.Airline.ICAOCode).FirstOrDefault();
                aircraft.Airline = airline;
                aircrafts.Add(aircraft);
            }
            return aircrafts;
        }

        private async Task<ObservableCollection<Aircraft>> ReplaceAirport(ObservableCollection<Aircraft> aircraftList)
        {
            ObservableCollection<Airport> airports = await _airportService.ListAllAsync();
            ObservableCollection<Aircraft> aircrafts = new ObservableCollection<Aircraft>();

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
