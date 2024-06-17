namespace Application.Permissions.Commands.CreatePermission
{
    public sealed record CreatePermissionRequest(
        string EmployeeForename,
        string EmployeeSurname,
        DateTime GrantedDate,
        int PermissionTypeId
        )
    {
    }
}