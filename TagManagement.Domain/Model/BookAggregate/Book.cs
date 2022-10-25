using System;
using Infrastructure.Domain;

namespace TagManagement.Domain.Model.BookAggregate
{
    public class Book : Entity<Guid>, IAggregateRoot
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public string BookName { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public Subject BookSubject { get; set; }
    }
}
