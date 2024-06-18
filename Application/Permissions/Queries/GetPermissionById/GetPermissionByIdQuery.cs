using Application.Abstractions.Messaging;

namespace Application.Permissions.Queries.GetPermissionById
{
    public sealed record GetPermissionByIdQuery(int Id) : IQuery<PermissionResponse>
    {
    }
}