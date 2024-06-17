using Application.Abstractions.Messaging;

namespace Application.Permissions.Commands.CreatePermission
{
    public sealed record CreatePermissionCommand(
        string EmployeeForename,
        string EmployeeSurname,
        DateTime GrantedDate,
        int PermissionTypeId
        )
        : ICommand<int>;
}