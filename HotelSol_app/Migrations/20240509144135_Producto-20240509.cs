using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelSol.Migrations
{
    /// <inheritdoc />
    public partial class Producto20240509 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    productoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idOdoo = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    list_price = table.Column<double>(type: "float", nullable: false),
                    qty_available = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.productoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_idOdoo",
                table: "Producto",
                column: "idOdoo");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_name",
                table: "Producto",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
