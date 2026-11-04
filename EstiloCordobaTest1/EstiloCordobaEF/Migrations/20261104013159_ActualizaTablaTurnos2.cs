using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class ActualizaTablaTurnos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idCliente",
                table: "Turnos",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idUsuario",
                table: "Turnos",
                column: "idUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_idCliente",
                table: "Turnos",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Empleados_idUsuario",
                table: "Turnos",
                column: "idUsuario",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_idCliente",
                table: "Turnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Empleados_idUsuario",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_idCliente",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_idUsuario",
                table: "Turnos");
        }
    }
}
