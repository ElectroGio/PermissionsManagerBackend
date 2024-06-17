using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Base
{
    public abstract class DomainObject : DomainBaseObject
    {
        [Key]
        public int Id { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not DomainObject item)
            {
                return false;
            }
            return this.Id.Equals(item.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}