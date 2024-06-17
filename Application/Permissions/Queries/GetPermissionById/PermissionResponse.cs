namespace Application.Permissions.Queries.GetPermissionById
{
    public sealed record PermissionResponse(int id, string EmployeeForename, string EmployeeSurname, DateTime GrantedDate, int permissionTypeId)
    {
    }
}