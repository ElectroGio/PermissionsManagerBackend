using Application.Abstractions.Messaging;

namespace Application.PermissionTypes.Queries.GetPermissionTypeById
{
    public sealed record GetPermissionTypeByIdQuery(int Id) : IQuery<PermissionTypeResponse>
    {
    }
}