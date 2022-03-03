﻿using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftTypeService : IAircraftTypeService
    {
        private static ObservableCollection<AircraftType> _aircraftTypeList = new ObservableCollection<AircraftType>
        {
            new AircraftType{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320", FirstFlight = DateTime.Parse("1987/02/22"), Lentgh = 37.57D, WingSpan = 34.10D, Height = 11.76D, EmptyWeight = 42400 },
            new AircraftType{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Brand = "Boeing", Type = "787-8", ICAOCode = "B788", FirstFlight = DateTime.Parse("2009/12/15"), Lentgh = 56.7D, WingSpan = 60.1D, Height = 16.9D, EmptyWeight = 118000 },
            new AircraftType{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11", FirstFlight = DateTime.Parse("1990/01/10"), Lentgh = 61.4D, WingSpan = 51.70D, Height = 17.6D, EmptyWeight = 112748 }
        };

        public async Task<AircraftType> AddAircraftType(AircraftType aircraftType)
        {
            _aircraftTypeList.Add(aircraftType);
            return await Task.FromResult(aircraftType);
        }

        public async Task<AircraftType> DeleteAircraftType(Guid aircraftTypeId)
        {
            AircraftType aircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == aircraftTypeId);
            _aircraftTypeList.Remove(aircraftType);
            return await Task.FromResult(aircraftType);
        }

        public async Task<AircraftType> GetAircraftTypeById(Guid aircraftTypeId)
        {
            AircraftType aircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == aircraftTypeId);
            return await Task.FromResult(aircraftType);
        }

        public async Task<IEnumerable<AircraftType>> GetAircraftTypes()
        {
            IEnumerable<AircraftType> aircraftTypes = _aircraftTypeList;
            return await Task.FromResult(aircraftTypes);
        }

        public async Task<AircraftType> UpdateAircraftType(AircraftType aircraftType)
        {
            AircraftType EditedAircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == aircraftType.Id);
            _aircraftTypeList.Remove(EditedAircraftType);
            _aircraftTypeList.Add(EditedAircraftType);
            return await Task.FromResult(EditedAircraftType);
        }
    }
}
