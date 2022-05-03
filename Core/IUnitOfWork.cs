using Core.IRepositories;

namespace Core
{
    public interface IUnitOfWork
    {
        void SaveAsync();
        IUserRepository Users { get; }
    }
}
