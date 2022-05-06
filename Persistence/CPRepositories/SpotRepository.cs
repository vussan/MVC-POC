using Core.IRepositories;
using Core.CounterPointModels;

namespace Persistence.Repositories
{
    public class SpotRepository : Repository<Spot>, ISpotRepository
    {
        public SpotRepository(AffWeb_XYZContext context) : base(context)
        {
        }
    }
}
