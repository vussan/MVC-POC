using Core.IRepositories;

namespace Core
{
    public interface ICPUnitOfWork
    {
        void SaveAsync();
        ISpotRepository Spots { get; }
    }
}
