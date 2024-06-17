using Application.Abstractions.Messaging;

using Dapper;

using Domain.Exceptions;

using System.Data;

namespace Application.Permissions.Queries.GetPermissionById
{
    public sealed class GetPermissionQueryHandler(IDbConnection dbConnection) : IQueryHandler<GetPermissionByIdQuery, PermissionResponse>
    {
        private readonly IDbConnection _dbConnection = dbConnection;

        public async Task<PermissionResponse> Handle(GetPermissionByIdQuery request, CancellationToken cancellationToken)
        {
            const string sql = @"SELECT * FROM ""Permissions"" WHERE ""Id"" = @Id";

            var permission = await _dbConnection.QueryFirstOrDefaultAsync<PermissionResponse>
                (sql,
                new { request.id });

            if (permission is null)
            {
                throw new PermissionNotFoundException(request.id);
            }
            return permission;
        }
    }
}