using InterSol.IManage.Data.Concretes;
using InterSol.IManage.Data.Databases;
using System;
using System.Data.Entity;

namespace InterSol.IManage.Data.Abstracts
{
    public abstract class UnitOfWork : IDisposable
    {
        #region Member Variables
        private DbContext _context;
        private IRepositoryFactory _repositoryFactory;
        private bool _disposed = false;
        #endregion

        #region Properties
        public DbContext DbContext
        {
            get { return _context ?? (_context = new IManageDb()); }
            private set { _context = value; }
        }

        public IRepositoryFactory RepositoryFactory
        {
            get { return _repositoryFactory ?? (_repositoryFactory = new GenericRepositoryFactory(DbContext)); }
            private set { _repositoryFactory = value; }
        }

        #endregion

        protected UnitOfWork(DbContext context)
        {
            DbContext = context;
            RepositoryFactory = new GenericRepositoryFactory(DbContext);
        }

        public abstract bool Commit();

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
