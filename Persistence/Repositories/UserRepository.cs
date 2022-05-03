using Core.IRepositories;
using Core.Models;

namespace Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDBContext context) : base(context)
        {
        }
    }
}
