using Microsoft.EntityFrameworkCore;
using NZWALK.Data;
using NZWALK.Models.Domain;

namespace NZWALK.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalkDbContext nZWalkDbContext;   
        public RegionRepository(NZWalkDbContext nZWalkDbContext)
        {
            this.nZWalkDbContext = nZWalkDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalkDbContext.Regions.ToListAsync();
        }
    }
}
