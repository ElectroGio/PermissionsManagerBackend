﻿using Application.Permissions.Commands.CreatePermission;
using Application.Permissions.Queries.GetPermissionById;

using Mapster;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class PermissionsController : ApiController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PermissionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPermission(int id, CancellationToken cancellationToken)
        {
            var query = new GetPermissionByIdQuery(id);

            var permission = await Sender.Send(query, cancellationToken);

            return Ok(permission);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatePermission(
            [FromBody] CreatePermissionRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreatePermissionCommand>();
            var permissionId = await Sender.Send(command, cancellationToken);
            return CreatedAtAction(nameof(GetPermission), new { permissionId }, permissionId);
        }
    }
}