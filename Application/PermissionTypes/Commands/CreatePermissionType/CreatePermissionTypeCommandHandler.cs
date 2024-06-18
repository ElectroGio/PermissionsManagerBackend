using Application.Abstractions.Messaging;

using Domain.Abstractions;
using Domain.Entities;

namespace Application.PermissionTypes.Commands.CreatePermissionType
{
    internal sealed class CreatePermissionTypeCommandHandler(IPermissionTypeRepository permissionTypeRepository, IUnitOfWork unitOfWork) : ICommandHandler<CreatePermissionTypeCommand, int>
    {
        private readonly IPermissionTypeRepository _permissionRepository = permissionTypeRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(CreatePermissionTypeCommand request, CancellationToken cancellationToken)
        {
            var permissionType = new PermissionType(
                request.Description
                );

            _permissionRepository.Insert(permissionType);
            await _unitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            return permissionType.Id;
        }
    }
}