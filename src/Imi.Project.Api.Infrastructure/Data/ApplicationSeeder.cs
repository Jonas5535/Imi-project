﻿using Imi.Project.Api.Core.Entities;
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
                    Length = 37.57D, WingSpan = 34.10D, Height = 11.76D, EmptyWeight = 42400, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "787-8", ICAOCode = "B788", FirstFlight = DateTime.Parse("2009/12/15"),
                    Length = 56.7D, WingSpan = 60.1D, Height = 16.9D, EmptyWeight = 118000, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11", FirstFlight = DateTime.Parse("1990/01/10"),
                    Length = 61.4D, WingSpan = 51.70D, Height = 17.6D, EmptyWeight = 112748, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A220-100", ICAOCode = "BCS1", FirstFlight = DateTime.Parse("2013/09/16"),
                    Length = 35.00D, WingSpan = 35.10D, Height = 11.50D, EmptyWeight = 35220, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A220-300", ICAOCode = "BCS3", FirstFlight = DateTime.Parse("2015/02/27"),
                    Length = 38.71D, WingSpan = 35.10D, Height = 11.50D, EmptyWeight = 37080, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A319-100", ICAOCode = "A319", FirstFlight = DateTime.Parse("1995/08/25"),
                    Length = 33.84D, WingSpan = 35.8D, Height = 11.76D, EmptyWeight = 40800, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A340-300", ICAOCode = "A343", FirstFlight = DateTime.Parse("1991/10/25"),
                    Length = 63.66D, WingSpan = 60.3D, Height = 16.99D, EmptyWeight = 131000, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A350-1000", ICAOCode = "A35K", FirstFlight = DateTime.Parse("2016/11/24"),
                    Length = 73.79D, WingSpan = 64.75D, Height = 17.08D, EmptyWeight = 155000, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Airbus", Type = "A380-800", ICAOCode = "A388", FirstFlight = DateTime.Parse("2005/04/27"),
                    Length = 72.72D, WingSpan = 79.75D, Height = 24.09D, EmptyWeight = 277145, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "747-8", ICAOCode = "B748", FirstFlight = DateTime.Parse("2010/02/08"),
                    Length = 76.3D, WingSpan = 68.4D, Height = 19.4D, EmptyWeight = 197100, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "777-300ER", ICAOCode = "B77W", FirstFlight = DateTime.Parse("2003/02/24"),
                    Length = 73.86D, WingSpan = 64.80D, Height = 18.5D, EmptyWeight = 167829, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Boeing", Type = "787-9", ICAOCode = "B789", FirstFlight = DateTime.Parse("2013/09/17"),
                    Length = 62.81D , WingSpan = 60.12D, Height = 17.02D, EmptyWeight = 128850, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new AircraftType{ Id = Guid.NewGuid(), Brand = "Embraer", Type = "E190", ICAOCode = "E190", FirstFlight = DateTime.Parse("2004/03/12"),
                    Length = 36.25D, WingSpan = 28.73D, Height = 10.57D, EmptyWeight = 27837, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
            };
            #endregion

            #region Airline
            Airline[] airlines = new Airline[]
            {
                new Airline{ Id = Guid.NewGuid(), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL", MainAirport = "Brussels Airport",
                    HeadQuarter = "Diegem, België", FleetSize = 49, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Airline{ Id = Guid.NewGuid(), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF", MainAirport = "Brussels Airport",
                    HeadQuarter = "Zaventem, België", FleetSize = 32, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Airline{ Id = Guid.NewGuid(), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC", MainAirport = "Frankfurt am Main",
                    HeadQuarter = "Frankfurt, Duitsland", FleetSize = 18, AddedOn = DateTime.Now, ModifiedOn = DateTime.Now }
            };
            #endregion

            #region Airport
            Airport[] airports = new Airport[]
            {
                new Airport{Id = Guid.NewGuid(), Name = "Brussels Airport", IATACode = "BRU", ICAOCode = "EBBR", ElevationAMSL = 56, RunwayAmount = 3,
                    TerminalAmount = 1, Country = "België", City = "Zaventem", AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Airport{Id = Guid.NewGuid(), Name = "Nice Côte d'Azur", IATACode = "NCE", ICAOCode = "LFMN", ElevationAMSL = 4, RunwayAmount = 2,
                    TerminalAmount = 3, Country = "Frankrijk", City = "Nice", AddedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Airport{Id = Guid.NewGuid(), Name = "Tokyo Narita Intl. Airport", IATACode = "NRT", ICAOCode = "RJAA", ElevationAMSL = 41, RunwayAmount = 2,
                    TerminalAmount = 3, Country = "japan", City = "Narita", AddedOn = DateTime.Now, ModifiedOn = DateTime.Now }
            };
            #endregion

            #region Aircraft
            Aircraft[] aircrafts = new Aircraft[]
            {
                new Aircraft{Id = Guid.NewGuid(), Registration = "OO-SNJ", AircraftTypeId = aircraftTypes[0].Id, AirlineId = airlines[0].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08), AddedOn = DateTime.Now, ModifiedOn = DateTime.Now},
                new Aircraft{Id = Guid.NewGuid(), Registration = "OO-LOE", AircraftTypeId = aircraftTypes[1].Id, AirlineId = airlines[1].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08), AddedOn = DateTime.Now, ModifiedOn = DateTime.Now},
                new Aircraft{Id = Guid.NewGuid(), Registration = "D-ALCC", AircraftTypeId = aircraftTypes[2].Id, AirlineId = airlines[2].Id,
                    HasSpecialLivery = false, FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25), AddedOn = DateTime.Now, ModifiedOn = DateTime.Now}
            };
            #endregion

            #region AircraftAtAirport
            AircraftAtAirport[] aircraftsAtAirports = new AircraftAtAirport[]
            {
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[0].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[1].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[0].Id, AirportId = airports[2].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[1].Id, AirportId = airports[0].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[1].Id, AirportId = airports[1].Id},
                new AircraftAtAirport{ AircraftId = aircrafts[2].Id, AirportId = airports[2].Id},
            };
            #endregion

            #region ModelBuilder
            modelBuilder.Entity<AircraftType>().HasData(aircraftTypes);
            modelBuilder.Entity<Airline>().HasData(airlines);
            modelBuilder.Entity<Airport>().HasData(airports);
            modelBuilder.Entity<Aircraft>().HasData(aircrafts);
            modelBuilder.Entity<AircraftAtAirport>().HasData(aircraftsAtAirports);
            #endregion
        }
    }
}
