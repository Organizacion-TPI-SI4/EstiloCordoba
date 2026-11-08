using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregaClaseNavegacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Atenciones_idBarbero",
                table: "Atenciones",
                column: "idBarbero");

            migrationBuilder.AddForeignKey(
                name: "FK_Atenciones_Empleados_idBarbero",
                table: "Atenciones",
                column: "idBarbero",
                principalTable: "Empleados",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atenciones_Empleados_idBarbero",
                table: "Atenciones");

            migrationBuilder.DropIndex(
                name: "IX_Atenciones_idBarbero",
                table: "Atenciones");
        }
    }
}
