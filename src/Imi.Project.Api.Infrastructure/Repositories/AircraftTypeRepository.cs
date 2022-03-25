using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Infrastructure.Data;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class AircraftTypeRepository : BaseRepository<AircraftType>, IAircraftTypeRepository
    {
        public AircraftTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
