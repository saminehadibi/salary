using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adibi.Migrations
{
    public partial class salary333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Overtime",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overtime",
                table: "Salareis");
        }
    }
}
