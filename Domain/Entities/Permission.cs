using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Permission : DomainObject
    {
        public Permission(string employeeForename,
            string employeeSurname,
            DateTime grantedDate,
            int permissionType
            )
        {
            EmployeeForename = employeeForename;
            EmployeeSurname = employeeSurname;
            GrantedDate = grantedDate;
            TypeId = permissionType;
        }

        private Permission()
        { }

        public  string EmployeeForename { get; private set; }
        public  string EmployeeSurname { get; private set; }
        public virtual  PermissionType Type { get; private set; }
        public int TypeId { get; private set; }
        public  DateTime GrantedDate { get; private set; }
    }
}