using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure.Repositories
{
    public interface IAircraftRepository : IBaseRepository<Aircraft>
    {
        Task<IEnumerable<Aircraft>> FilterAsync(bool? hasSpecialLivery, string registration, string type, string airlineName, string airportName);
    }
}
