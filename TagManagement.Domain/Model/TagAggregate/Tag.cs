using System;
using Infrastructure.Domain;
using TagManagement.Domain.Model.BookAggregate;

namespace TagManagement.Domain.Model.TagAggregate
{
    public abstract class Tag : Entity<Guid>, IAggregateRoot
    {
        public string Title { get; set; }
        public Subject TagSubject { get; set; }
        public string BookText { get; set; }
        public string TagSource { get; set; }
        public string Description { get; set; }
        public BookLocation BookLocation { get; set; }
    }

    public class BookLocation
    {
        public int Page { get; set; }
        public int Paragraph { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }

}
