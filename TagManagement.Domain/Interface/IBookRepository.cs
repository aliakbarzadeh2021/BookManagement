using System;
using Infrastructure.Repository;
using TagManagement.Domain.Model.BookAggregate;

namespace TagManagement.Domain.Interface
{
    public interface IBookRepository : IRepository<Book, Guid>, IQueryRepository<Book, Guid>
    {
    }

}