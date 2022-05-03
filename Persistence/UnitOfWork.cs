using Core;
using Core.IRepositories;
using Persistence.Repositories;

namespace Persistence
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDBContext _context;
        private readonly IUserRepository? _userRepository;

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }
        public IUserRepository Users { get => _userRepository ?? new UserRepository(_context); }
        public void SaveAsync() => _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
