using System.Collections.Generic;

namespace Infrastructure.Domain
{
    public interface IAggregateRoot
    {
    }

    public interface IValueObject<T> where T : class
    {
        bool SameValueAs(T valueObject);
    }

    public abstract class Entity<TId>
    {
        public TId Id { get; set; }

        protected bool Equals(Entity<TId> other)
        {
            return EqualityComparer<TId>.Default.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Entity<TId>) obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TId>.Default.GetHashCode(Id);
        }

        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity<TId> left, Entity<TId> right)
        {
            return !Equals(left, right);
        }
    }

    public abstract class ValueObject
    {
        
    }
}
