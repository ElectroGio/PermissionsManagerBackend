using Application.Abstractions.Messaging;

namespace Application.PermissionTypes.Commands.CreatePermissionType
{
    public sealed record CreatePermissionTypeCommand(
        string Description
        )
        : ICommand<int>;
}