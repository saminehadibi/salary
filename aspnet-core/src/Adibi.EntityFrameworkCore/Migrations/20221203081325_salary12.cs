using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adibi.Migrations
{
    public partial class salary12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Transportation",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Receipt",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BasicSalary",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Attraction",
                table: "Salareis",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Transportation",
                table: "Salareis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                table: "Salareis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Receipt",
                table: "Salareis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BasicSalary",
                table: "Salareis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Attraction",
                table: "Salareis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");
        }
    }
}
