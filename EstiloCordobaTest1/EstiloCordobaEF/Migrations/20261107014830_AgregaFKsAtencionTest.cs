using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregaFKsAtencionTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Clientes_idCliente",
                table: "Atenciones",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Estados_idEstado",
                table: "Atenciones",
                column: "idEstado",
                principalTable: "Estados",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Turnos_idTurno",
                table: "Atenciones",
                column: "idTurno",
                principalTable: "Turnos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Clientes_idCliente",
                table: "Atenciones",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Estados_idEstado",
                table: "Atenciones",
                column: "idEstado",
                principalTable: "Estados",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Turnos_idTurno",
                table: "Atenciones",
                column: "idTurno",
                principalTable: "Turnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
