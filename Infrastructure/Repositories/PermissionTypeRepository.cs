using Domain.Abstractions;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public sealed class PermissionTypeRepository : IPermissionTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PermissionTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Exists(int permissionTypeId)
        {
            var entity = _dbContext.Find<PermissionType>(permissionTypeId);
            return entity is not null;
        }

        public PermissionType? GetById(int id)
        {
            var entity = _dbContext.Find<PermissionType>(id);
            return entity;
        }

        public void Insert(PermissionType permissionType)
        {
            _dbContext.Set<PermissionType>().Add(permissionType);
        }
    }
}