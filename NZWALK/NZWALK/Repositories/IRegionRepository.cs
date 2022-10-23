using NZWALK.Models.Domain;

namespace NZWALK.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
