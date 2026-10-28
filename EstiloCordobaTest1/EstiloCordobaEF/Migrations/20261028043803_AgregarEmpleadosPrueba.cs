using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEmpleadosPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Clave", "Domicilio", "Email", "IdRol", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Admin", "Cordoba", "admin@estilocordoba.com", 1, "Administrador", "3510000001" },
                    { 2, "Test123", "Cordoba", "empleado@estilocordoba.com", 2, "Empleado de prueba", "3510000002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
