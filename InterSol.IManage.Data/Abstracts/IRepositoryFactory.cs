namespace InterSol.IManage.Data.Abstracts
{
    public interface IRepositoryFactory
    {
        IRepository<TEntity> CreatRepository<TEntity>() where TEntity : class;
    }
}
