using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class TablaMediosPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediosPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediosPago", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "MediosPago",
                columns: new[] { "id", "descripcion" },
                values: new object[,]
                {
                    { 1, "Efectivo/Transferencia" },
                    { 2, "Tarjeta de crédito" },
                    { 3, "Tarjeta de débito" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediosPago");
        }
    }
}
