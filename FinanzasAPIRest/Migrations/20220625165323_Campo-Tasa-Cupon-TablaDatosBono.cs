using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPIRest.Migrations
{
    public partial class CampoTasaCuponTablaDatosBono : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cupon",
                table: "DatosBono",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cupon",
                table: "DatosBono");
        }
    }
}
