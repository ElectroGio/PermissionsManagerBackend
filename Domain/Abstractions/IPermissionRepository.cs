using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IPermissionRepository
    {
        void Insert(Permission permission);
    }
}