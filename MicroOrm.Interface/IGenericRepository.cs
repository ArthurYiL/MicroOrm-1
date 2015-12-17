using System;
using System.Linq;
using System.Linq.Expressions;

namespace MicroOrm.Interface
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity Find(params object[] keyValues);
        TEntity Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        TEntity Update(TEntity entityToUpdate);
        IQueryable<TEntity> DataTable { get; }
    }
}
