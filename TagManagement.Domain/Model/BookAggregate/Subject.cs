using System;
using System.Collections.Generic;
using Infrastructure.Domain;

namespace TagManagement.Domain.Model.BookAggregate
{
    public class Subject : Entity<Guid>
    {
        public string Name { get; set; }
        public List<Subject> Subfields { get; set; }

        public void AddSubfields(Subject subject)
        {
            Subfields.Add(subject);
        }
    }
}