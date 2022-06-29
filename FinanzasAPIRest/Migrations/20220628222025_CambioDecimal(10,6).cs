using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPIRest.Migrations
{
    public partial class CambioDecimal106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VAN",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TREA_Bonista",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Escudo",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Emisor",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Bonista",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TCEA_Escudo",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TCEA_Emisor",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioBono",
                table: "IndicadorFinanciero",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorNominal",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorComercial",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TasaInteresMercado",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrimaRedencion",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InflacionAnual",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GastosAdicionales",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Flotacion",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Estructuracion",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cupon",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Colocacion",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cavali",
                table: "DatosBono",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VAN",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TREA_Bonista",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Escudo",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Emisor",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TIR_Bonista",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TCEA_Escudo",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TCEA_Emisor",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioBono",
                table: "IndicadorFinanciero",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorNominal",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorComercial",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TasaInteresMercado",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrimaRedencion",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InflacionAnual",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GastosAdicionales",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Flotacion",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Estructuracion",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cupon",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Colocacion",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cavali",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");
        }
    }
}
