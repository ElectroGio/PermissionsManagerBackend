using Application.PermissionTypes.Commands.CreatePermissionType;
using Application.PermissionTypes.Queries.GetPermissionTypeById;

using Mapster;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class PermissionTypesController : ApiController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PermissionTypeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPermissionTypeAsync(int id, CancellationToken cancellationToken)
        {
            var query = new GetPermissionTypeByIdQuery(id);

            var permissionType = await Sender.Send(query, cancellationToken);

            return Ok(permissionType);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ActionName(nameof(CreatePermissionTypeAsync))]
        public async Task<IActionResult> CreatePermissionTypeAsync(
            [FromBody] CreatePermissionTypeRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreatePermissionTypeCommand>();
            var permissionTypeId = await Sender.Send(command, cancellationToken);
            return CreatedAtAction(nameof(CreatePermissionTypeAsync), new { permissionTypeId }, permissionTypeId);
        }
    }
}