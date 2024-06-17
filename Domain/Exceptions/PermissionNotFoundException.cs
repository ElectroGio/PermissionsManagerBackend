using Domain.Exceptions.Base;

namespace Domain.Exceptions
{
    public sealed class PermissionNotFoundException : NotFoundException
    {
        public PermissionNotFoundException(int permissionId) :
            base($"The permission with the identifier {permissionId} was not found.")
        {
        }
    }
}