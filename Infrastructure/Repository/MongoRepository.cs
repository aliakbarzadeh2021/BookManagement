using System;
using System.Collections.Generic;
using Infrastructure.Domain;
using MongoDB.Driver;

namespace Infrastructure.Repository
{
    public class MongoRepository<TEntity,TId> : IRepository<TEntity,TId>, IQueryRepository<TEntity,TId> 
        where TEntity: Entity<TId>, IAggregateRoot
    {
        public IMongoClient Client;
        public IMongoDatabase Database;
        public IMongoCollection<TEntity> Collection;

        public MongoRepository()
        {
            string connectionString="mongodb://localhost:27017";
            string databaseName = "AliDB";
            Client = new MongoClient(connectionString);
            this.Database = Client.GetDatabase(databaseName);
            Collection = SetupCollection();
        }

        private IMongoCollection<TEntity> SetupCollection()
        {
            var collectionName = BuildCollectionName();
            var collection = Database.GetCollection<TEntity>(collectionName);
            return collection;
        }

        private string BuildCollectionName()
        {
            var collectionName = typeof(TEntity).Name.EndsWith("s") ? typeof(TEntity).Name : typeof(TEntity).Name + "s";
            return collectionName;
        }

        public void Insert(TEntity entity)
        {
            Collection.InsertOne(entity);
        }

        public void Update(TEntity entity)
        {
            var filter = Builders<TEntity>.Filter.Eq(d => d.Id, entity.Id);
            Collection.ReplaceOne(filter, entity);
        }

        public void Remove(TId id)
        {
            Collection.DeleteOne(Builders<TEntity>.Filter.Eq(d => d.Id, id));
        }

        public TEntity SelectById(TId id)
        {
            return Collection.Find(Builders<TEntity>.Filter.Eq(x => x.Id, id)).SingleOrDefault();
        }

        public IEnumerable<TEntity> SearchFor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Collection.Find(e => true).ToList();
        }

        public IMongoCollection<TEntity> GetCollection()
        {
            return this.Database.GetCollection<TEntity>(typeof(TEntity).Name);
        }
        public IMongoCollection<TEntity> GetCollection(string collectionName)
        {
            return this.Database.GetCollection<TEntity>(collectionName);
        }
    }
}
