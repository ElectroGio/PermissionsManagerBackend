using Application.Abstractions.Messaging;

using Dapper;

using Domain.Exceptions;

using System.Data;

namespace Application.PermissionTypes.Queries.GetPermissionTypeById
{
    public sealed class GetPermissionTypeQueryHandler(IDbConnection dbConnection) : IQueryHandler<GetPermissionTypeByIdQuery, PermissionTypeResponse>
    {
        private readonly IDbConnection _dbConnection = dbConnection;

        public async Task<PermissionTypeResponse> Handle(GetPermissionTypeByIdQuery request, CancellationToken cancellationToken)
        {
            const string sql = @"SELECT Id, Description FROM ""PermissionTypes"" WHERE ""Id"" = @Id";

            var permissionType = await _dbConnection.QueryFirstOrDefaultAsync<PermissionTypeResponse>
                (sql,
                new { request.Id });

            if (permissionType is null)
            {
                throw new PermissionTypeNotFoundException(request.Id);
            }
            return permissionType;
        }
    }
}