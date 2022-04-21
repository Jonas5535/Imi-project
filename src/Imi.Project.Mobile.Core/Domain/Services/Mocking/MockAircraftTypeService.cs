using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAircraftTypeService : ICRUDService<AircraftType>
    {
        private static ICollection<AircraftType> _aircraftTypeList = new List<AircraftType>
        {
            new AircraftType{ Id = Guid.Parse("4673e611-2495-4e0c-97e4-4abff97ae018"), Brand = "Airbus", Type = "A320-200", ICAOCode = "A320",
                FirstFlight = DateTime.Parse("1987/02/22"), Length = 37.57D, WingSpan = 34.10D, Height = 11.76D, EmptyWeight = 42400 },
            new AircraftType{ Id = Guid.Parse("a0979f14-e054-4928-a581-ddddd5aa2e89"), Brand = "Boeing", Type = "787-8", ICAOCode = "B788",
                FirstFlight = DateTime.Parse("2009/12/15"), Length = 56.7D, WingSpan = 60.1D, Height = 16.9D, EmptyWeight = 118000 },
            new AircraftType{ Id = Guid.Parse("e911ec3f-613e-443e-8756-50765d9ac40d"), Brand = "McDonnel Douglas", Type = "MD-11", ICAOCode = "MD11",
                FirstFlight = DateTime.Parse("1990/01/10"), Length = 61.4D, WingSpan = 51.70D, Height = 17.6D, EmptyWeight = 112748 }
        };

        public async Task<BaseResponse<AircraftType>> AddAsync(AircraftType entity)
        {
            _aircraftTypeList.Add(entity);
            BaseResponse<AircraftType> response = new BaseResponse<AircraftType>();
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<AircraftType>> DeleteAsync(Guid id)
        {
            AircraftType aircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == id);
            _aircraftTypeList.Remove(aircraftType);

            BaseResponse<AircraftType> response = new BaseResponse<AircraftType>();
            return await Task.FromResult(response);
        }

        public Task<AircraftType[]> GetAircraftTypes()
        {
            throw new NotImplementedException();
        }

        public Task<Airline[]> GetAirlines()
        {
            throw new NotImplementedException();
        }

        public Task<Airport[]> GetAirports()
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<AircraftType>> GetByIdAsync(Guid id)
        {
            AircraftType aircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == id);

            BaseResponse<AircraftType> response = new BaseResponse<AircraftType> { Data = aircraftType };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<ICollection<AircraftType>>> ListAllAsync()
        {
            ICollection<AircraftType> aircraftTypes = _aircraftTypeList;

            BaseResponse<ICollection<AircraftType>> response = new BaseResponse<ICollection<AircraftType>> { Data = aircraftTypes };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<AircraftType>> UpdateAsync(AircraftType entity)
        {
            AircraftType EditedAircraftType = _aircraftTypeList.FirstOrDefault(a => a.Id == entity.Id);
            _aircraftTypeList.Remove(EditedAircraftType);
            _aircraftTypeList.Add(EditedAircraftType);

            BaseResponse<AircraftType> response = new BaseResponse<AircraftType>();
            return await Task.FromResult(response);
        }
    }
}
