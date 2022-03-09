﻿using Imi.Project.Blazor.Core.CRUD.Models;
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
            new InputSelectItem() { Value = "1", Label = "A320"},
            new InputSelectItem() { Value = "2", Label = "B788"},
            new InputSelectItem() { Value = "3", Label = "MD11"}
        };

        private static InputSelectItem[] _airlines = new InputSelectItem[]
        {
            new InputSelectItem(){ Value = "1", Label = "Brussels Airlines"},
            new InputSelectItem(){ Value = "2", Label = "TUI Fly"},
            new InputSelectItem(){ Value = "3", Label = "LuftHansa Cargo"}
        };

        private static InputSelectItem[] _airports = new InputSelectItem[]
        {
            new InputSelectItem{ Value = "1", Label = "Brussels Airport"},
            new InputSelectItem{ Value = "2", Label = "Nice Côte d'Azur"},
            new InputSelectItem{ Value = "3", Label = "Tokyo Narita Intl. Airport"},
        };

        private static List<AircraftItem> _aircrafts = new List<AircraftItem>()
        {
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "OO-SNJ", AircraftTypeId = "1", AirlineId = "1", HasSpecialLivery = false,
                FirstSeen = new DateTime(2021, 07, 08), LastSeen = new DateTime(2021, 07, 08), AirportIds = new List<string>{ "1", "2", "3" } },
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "OO-LOE", AircraftTypeId = "2", AirlineId = "2", HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 13), LastSeen = new DateTime(2021, 07, 08), AirportIds = new List<string>{ "1", "2" } },
            new AircraftItem{ Id = Guid.NewGuid(), Registration = "D-ALCC", AircraftTypeId = "3", AirlineId = "3", HasSpecialLivery = false,
                FirstSeen = new DateTime(2020, 07, 29), LastSeen = new DateTime(2021, 07, 25), AirportIds = new List<string>{ "3", } },
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
                AircraftType = _aircraftTypes
                    .Where(at => at.Value == a.AircraftTypeId)
                    .Select(at => at.Label)
                    .SingleOrDefault(),
                Airline = _aircraftTypes
                    .Where(al => al.Value == a.AircraftTypeId)
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