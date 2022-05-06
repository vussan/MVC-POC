using Core;
using Core.IRepositories;
using Persistence.Repositories;

namespace Persistence
{
    public class CPUnitOfWork:ICPUnitOfWork
    {
        private readonly AffWeb_XYZContext _context;
        private readonly ISpotRepository? _spotRepository;

        public CPUnitOfWork(AffWeb_XYZContext context)
        {
            _context = context;
        }
        public ISpotRepository Spots { get => _spotRepository ?? new SpotRepository(_context); }
        public void SaveAsync() => _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
