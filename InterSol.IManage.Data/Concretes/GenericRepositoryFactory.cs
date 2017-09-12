using InterSol.IManage.Data.Abstracts;
using InterSol.IManage.Data.Databases;
using System.Data.Entity;

namespace InterSol.IManage.Data.Concretes
{
    class GenericRepositoryFactory : IRepositoryFactory
    {
        private IRepository<Person> _personRepository;
        private IRepository<Account> _accountRepository;
        private IRepository<Transaction> _transactionRepository;

        #region Properties
        public DbContext DbContext { get; }
        #endregion

        public GenericRepositoryFactory(DbContext context)
        {
            DbContext = context;
        }

        public IRepository<TEntity> CreatRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(DbContext);
        }

        public IRepository<Person> PersonRepository => _personRepository ?? (_personRepository = CreatRepository<Person>());
        public IRepository<Account> AccountRepository => _accountRepository ?? (_accountRepository = CreatRepository<Account>());
        public IRepository<Transaction> TransactionRepository => _transactionRepository ?? (_transactionRepository = CreatRepository<Transaction>());
    }
}
