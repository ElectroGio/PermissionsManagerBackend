using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Permission : DomainObject
    {
        public string EmployeeForename { get; private set; }
        public string EmployeeSurname { get; private set; }
        public virtual PermissionType PermissionType { get; private set; }
        public int PermissionTypeId { get; private set; }
        public DateTime GrantedDate { get; private set; }

        private Permission()
        {
            EmployeeForename = string.Empty;
            EmployeeSurname = string.Empty;
            PermissionTypeId = 0;
            PermissionType = new PermissionType(string.Empty);
            GrantedDate = DateTime.MinValue;
        }

        public Permission(string employeeForename,
            string employeeSurname,
            DateTime grantedDate,
            PermissionType permissionType
            )
        {
            EmployeeForename = employeeForename;
            EmployeeSurname = employeeSurname;
            GrantedDate = grantedDate;
            PermissionType = permissionType;
        }
    }
}