using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region AircraftType
            AircraftType[] aircraftTypes = new AircraftType[]
            {
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320", FirstFlight = DateTime.Parse("1987/02/22"),
                    Length = 37.57D, WingSpan = 34.10D, Height = 11.76D, EmptyWeight = 42400 },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "787-8", ICAOCode = "B788", FirstFlight = DateTime.Parse("2009/12/15"),
                    Length = 56.7D, WingSpan = 60.1D, Height = 16.9D, EmptyWeight = 118000 },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11", FirstFlight = DateTime.Parse("1990/01/10"),
                    Length = 61.4D, WingSpan = 51.70D, Height = 17.6D, EmptyWeight = 112748 }
            };
            #endregion

            #region Airline
            Airline[] airlines = new Airline[]
            {
                new Airline{ Id = Guid.NewGuid(), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL", MainAirport = "Brussels Airport",
                    HeadQuarter = "Diegem, België", FleetSize = 49 },
                new Airline{ Id = Guid.NewGuid(), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF", MainAirport = "Brussels Airport",
                    HeadQuarter = "Zaventem, België", FleetSize = 32 },
                new Airline{ Id = Guid.NewGuid(), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC", MainAirport = "Frankfurt am Main",
                    HeadQuarter = "Frankfurt, Duitsland", FleetSize = 18 }
            };
            #endregion

            #region Airport
            Airport[] airports = new Airport[]
            {
                new Airport{Id = Guid.NewGuid(), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR", ElevationAMSL = 56, RunwayAmount = 3,
                    TerminalAmount = 1, Country = "België", City = "Zaventem" },
                new Airport{Id = Guid.NewGuid(), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN", ElevationAMSL = 4, RunwayAmount = 2,
                    TerminalAmount = 3, Country = "Frankrijk", City = "Nice" },
                new Airport{Id = Guid.NewGuid(), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA", ElevationAMSL = 41, RunwayAmount = 2,
                    TerminalAmount = 3, Country = "japan", City = "Narita" }
            };
            #endregion

            #region Aircraft
            Aircraft[] aircrafts = new Aircraft[]
            {
                new Aircraft{Id = Guid.NewGuid(), Registration = "OO-SNJ", AircraftTypeId = aircraftTypes[0].Id, AirlineId = airlines[0].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08)},
                new Aircraft{Id = Guid.NewGuid(), Registration = "OO-LOE", AircraftTypeId = aircraftTypes[1].Id, AirlineId = airlines[1].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08)},
                new Aircraft{Id = Guid.NewGuid(), Registration = "D-ALCC", AircraftTypeId = aircraftTypes[2].Id, AirlineId = airlines[2].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25)}
            };
            #endregion

            #region AircraftAtAirport
            AircraftAtAirport[] aircraftsAtAirports = new AircraftAtAirport[]
            {
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[0].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[1].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[2].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[1].Id, AirportId = airports[0].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[1].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[2].Id, AirportId = airports[2].Id},
            };
            #endregion

            #region ModelBuilder
            modelBuilder.Entity<AircraftType>().HasData(aircraftTypes);
            modelBuilder.Entity<Airline>().HasData(airlines);
            modelBuilder.Entity<Airport>().HasData(airports);
            modelBuilder.Entity<Aircraft>().HasData(aircrafts);
            #endregion
        }
    }
}
