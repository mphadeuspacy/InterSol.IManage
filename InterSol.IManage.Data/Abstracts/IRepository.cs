using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InterSol.IManage.Data.Abstracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
          Expression<Func<TEntity, bool>> filter = null,
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
          string includeProperties = "");

        void Insert(TEntity entity);

        void Update(TEntity entityToUpdate);

    }
}
