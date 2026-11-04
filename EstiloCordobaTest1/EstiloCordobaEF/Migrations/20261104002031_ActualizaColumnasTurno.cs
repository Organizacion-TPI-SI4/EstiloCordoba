using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class ActualizaColumnasTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_idClienteId",
                table: "Turnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Empleados_idUsuarioId",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_idClienteId",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_idUsuarioId",
                table: "Turnos");

            migrationBuilder.RenameColumn(
                name: "idUsuarioId",
                table: "Turnos",
                newName: "idUsuario");

            migrationBuilder.RenameColumn(
                name: "idClienteId",
                table: "Turnos",
                newName: "idCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "Turnos",
                newName: "idUsuarioId");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Turnos",
                newName: "idClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idClienteId",
                table: "Turnos",
                column: "idClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idUsuarioId",
                table: "Turnos",
                column: "idUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_idClienteId",
                table: "Turnos",
                column: "idClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Empleados_idUsuarioId",
                table: "Turnos",
                column: "idUsuarioId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
