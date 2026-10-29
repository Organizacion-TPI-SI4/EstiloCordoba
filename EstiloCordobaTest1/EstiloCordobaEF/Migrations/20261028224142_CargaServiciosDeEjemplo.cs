using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class CargaServiciosDeEjemplo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "CategoriaId", "Duracion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "30 minutos", "Corte de cabello", 8000m },
                    { 2, 2, "120 minutos", "Coloración", 25000m },
                    { 3, 1, "45 minutos", "Peinado", 12000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
