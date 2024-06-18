using FluentValidation;

namespace Application.PermissionTypes.Commands.CreatePermissionType
{
    public sealed class CreatePermissionTypeCommandValidator : AbstractValidator<CreatePermissionTypeCommand>
    {
        public CreatePermissionTypeCommandValidator()
        {
            RuleFor(x => x.Description).NotEmpty().Length(1,255);
        }
    }
}