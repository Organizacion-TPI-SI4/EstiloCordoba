using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class MailYClaveEmpleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clave",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clave",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Empleados");
        }
    }
}
