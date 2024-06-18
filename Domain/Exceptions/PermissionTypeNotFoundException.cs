using Domain.Exceptions.Base;

namespace Domain.Exceptions
{
    public sealed class PermissionTypeNotFoundException : NotFoundException
    {
        public PermissionTypeNotFoundException(int permissionTypeId) :
            base($"The permission type with the identifier {permissionTypeId} was not found.")
        {
        }
    }
}