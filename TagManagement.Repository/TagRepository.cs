using System;
using Infrastructure.Repository;
using TagManagement.Domain.Interface;
using TagManagement.Domain.Model.TagAggregate;

namespace TagManagement.Repository
{
    public class TagRepository : MongoRepository<Tag ,Guid>, ITagRepository
    {
        
    }
}