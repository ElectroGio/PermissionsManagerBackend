using Domain.Abstractions;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public sealed class PermissionRepository : IPermissionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PermissionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(Permission permission)
        {
            _dbContext.Set<Permission>().Add(permission);
        }
    }
}