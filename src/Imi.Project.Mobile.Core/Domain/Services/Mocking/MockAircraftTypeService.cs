using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftTypeService : IAircraftTypeService
    {
        private static ObservableCollection<AircraftType> _aircraftTypeList;

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
