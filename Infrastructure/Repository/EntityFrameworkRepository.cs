using System;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public class EntityFrameworkRepository<TEntity,TId> : IRepository<TEntity, TId>, IQueryRepository<TEntity, TId>
    {
        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(TId id)
        {
            throw new NotImplementedException();
        }

        public TEntity SelectById(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> SearchFor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}