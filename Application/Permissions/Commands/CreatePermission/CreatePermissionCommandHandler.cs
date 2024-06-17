using Application.Abstractions.Messaging;

using Domain.Abstractions;
using Domain.Entities;

namespace Application.Permissions.Commands.CreatePermission
{
    internal sealed class CreatePermissionCommandHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork) : ICommandHandler<CreatePermissionCommand, int>
    {
        private readonly IPermissionRepository _permissionRepository = permissionRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = new Permission(
                request.EmployeeForename,
                request.EmployeeSurname,
                request.GrantedDate,
                request.PermissionTypeId);

            _permissionRepository.Insert(permission);
            await _unitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            return permission.Id;
        }
    }
}