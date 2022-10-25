using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public interface IRepository<in TEntity,in TId>
    {
        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Remove(TId id);
    }


    public interface IQueryRepository<out TEntity, in TId>
    {
        TEntity SelectById(TId id);

        IEnumerable<TEntity> SearchFor();

        IEnumerable<TEntity> GetAll();
    }
}
