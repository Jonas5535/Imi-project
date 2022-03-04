using Imi.Project.Blazor.Core.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services.Hardcoded
{
    public class AircraftService : ICRUDService<AircraftListItem, AircraftItem>
    {
        private static InputSelectItem[] aircraftTypes = new InputSelectItem[]
        {

        };

        public Task AddAsync(AircraftItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AircraftItem> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AircraftListItem[]> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AircraftItem item)
        {
            throw new NotImplementedException();
        }
    }
}
