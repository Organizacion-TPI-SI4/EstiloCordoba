using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class RepararColumnasAtencion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
               name: "totalServicios",
               table: "Atenciones",
               type: "decimal(18,2)",
               precision: 18,
               scale: 2,
               nullable: false,
               defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "totalProductos",
                table: "Atenciones",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "totalServicios",
               table: "Atenciones");

            migrationBuilder.DropColumn(
                name: "totalProductos",
                table: "Atenciones");
        }
    }
}
