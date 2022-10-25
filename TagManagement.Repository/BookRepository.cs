using System;
using Infrastructure.Repository;
using TagManagement.Domain.Interface;
using TagManagement.Domain.Model.BookAggregate;

namespace TagManagement.Repository
{
    public class BookRepository : MongoRepository<Book, Guid>, IBookRepository
    {

    }
}
