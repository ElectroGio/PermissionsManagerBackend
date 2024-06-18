using Domain.Entities.Base;

namespace Domain.Entities
{
    public class PermissionType : DomainObject
    {
        public string Description { get; private set; }

        public PermissionType(string description)
        {
            Description = description;
        }

        private PermissionType()
        {
            Description = string.Empty;
        }
    }
}