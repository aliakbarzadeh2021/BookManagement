using System;
using Infrastructure.Repository;
using TagManagement.Domain.Model.TagAggregate;

namespace TagManagement.Domain.Interface
{
    public interface ITagRepository : IRepository<Tag, Guid>, IQueryRepository<Tag, Guid>
    {
    }
}