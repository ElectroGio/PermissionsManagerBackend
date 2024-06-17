using Domain.Exceptions.Base;

namespace Application.Exceptions
{
    public sealed class ValidationException : BadRequestException
    {
        public Dictionary<string, string[]> Errors { get; }

        public ValidationException(Dictionary<string, string[]> errors) : base("Validation errors ocurred")
        {
            Errors = errors;
        }
    }
}