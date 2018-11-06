

namespace MilgamPortalRepository
{
    public interface IUnitOfwork
    {
        // Save pending changes to the data store.
        void Save();

        // Repositories
        GenericRepository<Municipalities> MunicipalityRepository { get; }


    }
}
