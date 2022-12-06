using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adibi.Migrations
{
    public partial class salary556 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Attraction",
                table: "Salareis",
                newName: "Allowance");

            migrationBuilder.AlterColumn<string>(
                name: "TargetNotifiers",
                table: "AbpUserNotifications",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TargetNotifiers",
                table: "AbpNotifications",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Allowance",
                table: "Salareis",
                newName: "Attraction");

            migrationBuilder.AlterColumn<string>(
                name: "TargetNotifiers",
                table: "AbpUserNotifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TargetNotifiers",
                table: "AbpNotifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);
        }
    }
}
