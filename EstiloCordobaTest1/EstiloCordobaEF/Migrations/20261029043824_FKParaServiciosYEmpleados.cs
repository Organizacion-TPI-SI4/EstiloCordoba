using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class FKParaServiciosYEmpleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CategoriaId",
                table: "Servicios",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados",
                column: "IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados",
                column: "IdRol",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Categorias_CategoriaId",
                table: "Servicios",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Categorias_CategoriaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_CategoriaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados");
        }
    }
}
