using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PermissionTypes.Commands.CreatePermissionType
{
    public sealed record CreatePermissionTypeRequest(
        string Description
        )
    {
    }
}