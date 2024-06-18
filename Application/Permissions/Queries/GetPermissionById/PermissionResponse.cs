namespace Application.Permissions.Queries.GetPermissionById
{
    public sealed record PermissionResponse(int Id, string EmployeeForename, string EmployeeSurname, DateTime GrantedDate, int PermissionTypeId)
    {
    }
}