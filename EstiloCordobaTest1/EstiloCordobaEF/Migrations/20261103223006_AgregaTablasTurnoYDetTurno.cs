using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablasTurnoYDetTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuarioId = table.Column<int>(type: "int", nullable: false),
                    idClienteId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    Hora = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turnos_Clientes_idClienteId",
                        column: x => x.idClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turnos_Empleados_idUsuarioId",
                        column: x => x.idUsuarioId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesTurno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTurnoPadre = table.Column<int>(type: "int", nullable: false),
                    idServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesTurno", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetallesTurno_Servicios_idServicio",
                        column: x => x.idServicio,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesTurno_Turnos_idTurnoPadre",
                        column: x => x.idTurnoPadre,
                        principalTable: "Turnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTurno_idServicio",
                table: "DetallesTurno",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTurno_idTurnoPadre",
                table: "DetallesTurno",
                column: "idTurnoPadre");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idClienteId",
                table: "Turnos",
                column: "idClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_idUsuarioId",
                table: "Turnos",
                column: "idUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesTurno");

            migrationBuilder.DropTable(
                name: "Turnos");
        }
    }
}
