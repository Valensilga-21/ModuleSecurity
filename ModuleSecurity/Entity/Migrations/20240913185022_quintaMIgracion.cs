using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class quintaMIgracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CountrieId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCountrieId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountrieId",
                table: "Persons",
                column: "CountrieId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IdCountrieId",
                table: "Persons",
                column: "IdCountrieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Countries_CountrieId",
                table: "Persons",
                column: "CountrieId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Countries_IdCountrieId",
                table: "Persons",
                column: "IdCountrieId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countries_CountrieId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countries_IdCountrieId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CountrieId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_IdCountrieId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CountrieId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IdCountrieId",
                table: "Persons");

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
    }
}
