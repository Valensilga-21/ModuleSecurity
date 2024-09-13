using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class cuartaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountrieId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdConutrieId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CountrieId",
                table: "Roles",
                column: "CountrieId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_IdConutrieId",
                table: "Roles",
                column: "IdConutrieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Countries_CountrieId",
                table: "Roles",
                column: "CountrieId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Countries_IdConutrieId",
                table: "Roles",
                column: "IdConutrieId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Countries_CountrieId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Countries_IdConutrieId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CountrieId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_IdConutrieId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CountrieId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IdConutrieId",
                table: "Roles");
        }
    }
}
