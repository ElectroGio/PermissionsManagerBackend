using FluentValidation;

namespace Application.Permissions.Commands.CreatePermission
{
    public sealed class CreatePermissionCommandValidator : AbstractValidator<CreatePermissionCommand>
    {
        public CreatePermissionCommandValidator()
        {
            RuleFor(x => x.EmployeeForename).NotEmpty().Length(1,255);
            RuleFor(x => x.EmployeeSurname).NotEmpty().Length(1, 255);
            RuleFor(x => x.GrantedDate).NotEmpty();
            RuleFor(x => x.PermissionTypeId).NotEmpty();
        }
    }
}