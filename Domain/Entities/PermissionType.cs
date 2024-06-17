using Domain.Entities.Base;

namespace Domain.Entities
{
    public class PermissionType : DomainObject
    {
        public required string Description { get; set; }
    }
}