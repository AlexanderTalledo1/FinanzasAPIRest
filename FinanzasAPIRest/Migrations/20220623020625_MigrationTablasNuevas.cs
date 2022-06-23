using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPIRest.Migrations
{
    public partial class MigrationTablasNuevas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Moneda");

            //migrationBuilder.DropTable(
            //    name: "Tasa");

            //migrationBuilder.DropTable(
            //    name: "UnidadTiempo");

            migrationBuilder.CreateTable(
                name: "FrecuenciaPago",
                columns: table => new
                {
                    IdFrecuencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUnidad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrecuenciaPago", x => x.IdFrecuencia);
                });

            migrationBuilder.CreateTable(
                name: "DatosBono",
                columns: table => new
                {
                    IdOperacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorNominal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ValorComercial = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Plazo = table.Column<int>(type: "int", nullable: false),
                    TasaInteresMercado = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrimaRedencion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Estructuracion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Colocacion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Flotacion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Cavali = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GastosAdicionales = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    InflacionAnual = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdFrecuencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosBono", x => x.IdOperacion);
                    table.ForeignKey(
                        name: "FK_DatosBono_FrecuenciaPago_IdFrecuencia",
                        column: x => x.IdFrecuencia,
                        principalTable: "FrecuenciaPago",
                        principalColumn: "IdFrecuencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosBono_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndicadorFinanciero",
                columns: table => new
                {
                    IdIndicador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIR_Emisor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TCEA_Emisor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TIR_Escudo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TCEA_Escudo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TIR_Bonista = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TREA_Bonista = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecioBono = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    VAN = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IdOperacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicadorFinanciero", x => x.IdIndicador);
                    table.ForeignKey(
                        name: "FK_IndicadorFinanciero_DatosBono_IdOperacion",
                        column: x => x.IdOperacion,
                        principalTable: "DatosBono",
                        principalColumn: "IdOperacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosBono_IdFrecuencia",
                table: "DatosBono",
                column: "IdFrecuencia");

            migrationBuilder.CreateIndex(
                name: "IX_DatosBono_IdUsuario",
                table: "DatosBono",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_IndicadorFinanciero_IdOperacion",
                table: "IndicadorFinanciero",
                column: "IdOperacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicadorFinanciero");

            migrationBuilder.DropTable(
                name: "DatosBono");

            migrationBuilder.DropTable(
                name: "FrecuenciaPago");

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
    }
}
