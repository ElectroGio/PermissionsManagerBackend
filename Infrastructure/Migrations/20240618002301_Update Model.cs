using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_PermissionTypes_TypeId",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Permissions",
                newName: "PermissionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_TypeId",
                table: "Permissions",
                newName: "IX_Permissions_PermissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "PermissionTypeId",
                table: "Permissions",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                newName: "IX_Permissions_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_PermissionTypes_TypeId",
                table: "Permissions",
                column: "TypeId",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
