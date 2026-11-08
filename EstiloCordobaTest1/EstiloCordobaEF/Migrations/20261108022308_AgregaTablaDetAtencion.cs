using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaDetAtencion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetAtencion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAtencion = table.Column<int>(type: "int", nullable: false),
                    idProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    atencionid = table.Column<int>(type: "int", nullable: true),
                    productoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetAtencion", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetAtencion_Atenciones_atencionid",
                        column: x => x.atencionid,
                        principalTable: "Atenciones",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DetAtencion_Productos_productoId",
                        column: x => x.productoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetAtencion_atencionid",
                table: "DetAtencion",
                column: "atencionid");

            migrationBuilder.CreateIndex(
                name: "IX_DetAtencion_productoId",
                table: "DetAtencion",
                column: "productoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetAtencion");
        }
    }
}
