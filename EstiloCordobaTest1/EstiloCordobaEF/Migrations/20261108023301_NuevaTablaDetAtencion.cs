using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstiloCordobaEF.Migrations
{
    /// <inheritdoc />
    public partial class NuevaTablaDetAtencion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetAtencion_Atenciones_atencionid",
                table: "DetAtencion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetAtencion_Productos_productoId",
                table: "DetAtencion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetAtencion",
                table: "DetAtencion");

            migrationBuilder.RenameTable(
                name: "DetAtencion",
                newName: "DetallesAtencion");

            migrationBuilder.RenameColumn(
                name: "atencionid",
                table: "DetallesAtencion",
                newName: "Atencionid");

            migrationBuilder.RenameIndex(
                name: "IX_DetAtencion_productoId",
                table: "DetallesAtencion",
                newName: "IX_DetallesAtencion_productoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetAtencion_atencionid",
                table: "DetallesAtencion",
                newName: "IX_DetallesAtencion_Atencionid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesAtencion",
                table: "DetallesAtencion",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesAtencion_Atenciones_Atencionid",
                table: "DetallesAtencion",
                column: "Atencionid",
                principalTable: "Atenciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesAtencion_Productos_productoId",
                table: "DetallesAtencion",
                column: "productoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesAtencion_Atenciones_Atencionid",
                table: "DetallesAtencion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesAtencion_Productos_productoId",
                table: "DetallesAtencion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesAtencion",
                table: "DetallesAtencion");

            migrationBuilder.RenameTable(
                name: "DetallesAtencion",
                newName: "DetAtencion");

            migrationBuilder.RenameColumn(
                name: "Atencionid",
                table: "DetAtencion",
                newName: "atencionid");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesAtencion_productoId",
                table: "DetAtencion",
                newName: "IX_DetAtencion_productoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesAtencion_Atencionid",
                table: "DetAtencion",
                newName: "IX_DetAtencion_atencionid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetAtencion",
                table: "DetAtencion",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetAtencion_Atenciones_atencionid",
                table: "DetAtencion",
                column: "atencionid",
                principalTable: "Atenciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetAtencion_Productos_productoId",
                table: "DetAtencion",
                column: "productoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }
    }
}
