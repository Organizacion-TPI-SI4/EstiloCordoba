using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregaClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Beneficio_IdBeneficio",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Red_social",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdBeneficio",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "Email", "IdBeneficio", "Nombre", "Red_social", "Telefono", "localidad", "numeroDni", "tipoDni" },
                values: new object[] { 1, "Apellido de prueba", "cliente@estilocordoba.com", null, "Cliente de prueba", "Instagram: @clientedeprueba", "3510000003", "Cordoba", 12345678, "A" });

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Beneficio_IdBeneficio",
                table: "Clientes",
                column: "IdBeneficio",
                principalTable: "Beneficio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Beneficio_IdBeneficio",
                table: "Clientes");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Red_social",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdBeneficio",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Beneficio_IdBeneficio",
                table: "Clientes",
                column: "IdBeneficio",
                principalTable: "Beneficio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
