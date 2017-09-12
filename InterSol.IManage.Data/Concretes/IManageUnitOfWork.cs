using InterSol.IManage.Data.Abstracts;
using System.Data.Entity;

namespace InterSol.IManage.Data.Concretes
{
    public class IManageUnitOfWork : UnitOfWork
    {
        public IManageUnitOfWork(DbContext dbContext)
            : base(dbContext)
        { }

        public override bool Commit()
        {
            return DbContext.SaveChanges() > 0;
        }
    }
}
