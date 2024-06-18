using Application.Abstractions.Messaging;

using Domain.Abstractions;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Exceptions.Base;

namespace Application.Permissions.Commands.CreatePermission
{
    internal sealed class CreatePermissionCommandHandler(IPermissionRepository permissionRepository, IPermissionTypeRepository permissionTypeRepository,  IUnitOfWork unitOfWork) : ICommandHandler<CreatePermissionCommand, int>
    {
        private readonly IPermissionRepository _permissionRepository = permissionRepository;
        private readonly IPermissionTypeRepository _permissionTypeRepository = permissionTypeRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permissionType = _permissionTypeRepository.GetById(request.PermissionTypeId);
            if (permissionType is not null)
            {
                var permission = new Permission(
                  request.EmployeeForename,
                  request.EmployeeSurname,
                  request.GrantedDate,
                  permissionType);

                _permissionRepository.Insert(permission);
                await _unitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                return permission.Id;
            }
            throw new PermissionTypeNotFoundException(request.PermissionTypeId);
        }
    }
}