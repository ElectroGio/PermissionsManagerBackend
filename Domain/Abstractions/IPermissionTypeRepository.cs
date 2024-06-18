using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IPermissionTypeRepository
    {
        void Insert(PermissionType permissionType);

        PermissionType? GetById(int id);

        bool Exists(int permissionTypeId);


    }
}