using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class AircraftRepository : BaseRepository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IQueryable<Aircraft> GetAll()
        {
            return _dbContext.Aircrafts.AsNoTracking()
                .Include(a => a.AircraftType)
                .Include(a => a.Airline)
                .Include(a => a.SpottedAtAirports)
                    .ThenInclude(a => a.Airport);
        }

        public override async Task<IEnumerable<Aircraft>> ListAllAsync()
        {
            List<Aircraft> aircrafts = await GetAll().ToListAsync();
            return aircrafts;
        }

        public override async Task<Aircraft> GetByIdAsync(Guid id)
        {
            Aircraft aircraft = await GetAll().SingleOrDefaultAsync(a => a.Id.Equals(id));
            return aircraft;
        }
    }
}
