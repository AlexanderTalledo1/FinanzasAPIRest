using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPIRest.Migrations
{
    public partial class TableMonedaTasaUnidadtiempo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMoneda = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.IdMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Tasa",
                columns: table => new
                {
                    IdTasa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTasa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasa", x => x.IdTasa);
                });

            migrationBuilder.CreateTable(
                name: "UnidadTiempo",
                columns: table => new
                {
                    IdUnidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUnidad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadTiempo", x => x.IdUnidad);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Tasa");

            migrationBuilder.DropTable(
                name: "UnidadTiempo");
        }
    }
}
