using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class terceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Persons",
                newName: "UpdateAt");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Persons",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Persons",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Persons",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Persons",
                newName: "DeletedAt");

            migrationBuilder.AlterColumn<short>(
                name: "Phone",
                table: "Persons",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<short>(
                name: "Document",
                table: "Persons",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "Persons",
                type: "longtext",
                nullable: false);
        }
    }
}
