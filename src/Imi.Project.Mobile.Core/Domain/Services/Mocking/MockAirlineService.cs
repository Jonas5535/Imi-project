using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAirlineService : ICRUDService<Airline>
    {
        private static ICollection<Airline> _airlineList = new List<Airline>
        {
            new Airline{ Id = Guid.Parse("cd8cf99b-d0c0-4de8-b708-46573523afe5"), Name = "Brussels Airlines", IATACode = "SN", ICAOCode = "BEL",
                MainAirport = "Brussels Airport", HeadQuarter = "Diegem, België", FleetSize = 49 },
            new Airline{ Id = Guid.Parse("4e0b7e94-455c-485b-87d4-a357459a6ac1"), Name = "TUI Fly", IATACode = "TB", ICAOCode = "JAF",
                MainAirport = "Brussels Airport", HeadQuarter = "Zaventem, België", FleetSize = 32 },
            new Airline{ Id = Guid.Parse("0f1a0904-46f9-406a-afc2-460746623ad6"), Name = "Lufthansa Cargo", IATACode = "LH", ICAOCode = "GEC",
                MainAirport = "Frankfurt am Main", HeadQuarter = "Frankfurt, Duitsland", FleetSize = 18 }
        };

        public async Task<BaseResponse<Airline>> AddAsync(Airline entity)
        {
            _airlineList.Add(entity);
            BaseResponse<Airline> response = new BaseResponse<Airline>();
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<Airline>> DeleteAsync(Guid id)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == id);
            _airlineList.Remove(airline);

            BaseResponse<Airline> response = new BaseResponse<Airline>();
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

        public async Task<BaseResponse<Airline>> GetByIdAsync(Guid id)
        {
            Airline airline = _airlineList.FirstOrDefault(a => a.Id == id);

            BaseResponse<Airline> response = new BaseResponse<Airline> { Data = airline };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<ICollection<Airline>>> ListAllAsync()
        {
            ICollection<Airline> airlines = _airlineList;

            BaseResponse<ICollection<Airline>> response = new BaseResponse<ICollection<Airline>> { Data = airlines };
            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<Airline>> UpdateAsync(Airline entity)
        {
            Airline EditedAirline = _airlineList.FirstOrDefault(a => a.Id == entity.Id);
            _airlineList.Remove(EditedAirline);
            _airlineList.Add(EditedAirline);

            BaseResponse<Airline> response = new BaseResponse<Airline>();
            return await Task.FromResult(response);
        }
    }
}
