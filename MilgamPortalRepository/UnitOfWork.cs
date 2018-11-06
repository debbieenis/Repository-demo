using System;

namespace MilgamPortalRepository
{
    public class UnitOfWork : IUnitOfwork, IDisposable
    {

        private MilgamPortalEntities context = new MilgamPortalEntities();

        private GenericRepository<Municipalities> municipalityRepository;

        private bool disposed = false;
        public GenericRepository<Municipalities> MunicipalityRepository
        {
            get
            {

                if (this.municipalityRepository == null)
                {
                    this.municipalityRepository = new GenericRepository<Municipalities>(context);
                }
                return municipalityRepository;
            }
        }

    


        public void Save()
        {
            context.SaveChanges();
        }
              

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
