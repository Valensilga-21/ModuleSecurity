using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class sextaMIgracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countries_CountrieId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countries_IdCountrieId",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "IdCountrieId",
                table: "Persons",
                newName: "IdCityId");

            migrationBuilder.RenameColumn(
                name: "CountrieId",
                table: "Persons",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_IdCountrieId",
                table: "Persons",
                newName: "IX_Persons_IdCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_CountrieId",
                table: "Persons",
                newName: "IX_Persons_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Cities_CityId",
                table: "Persons",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Cities_IdCityId",
                table: "Persons",
                column: "IdCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Cities_CityId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Cities_IdCityId",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "IdCityId",
                table: "Persons",
                newName: "IdCountrieId");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Persons",
                newName: "CountrieId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_IdCityId",
                table: "Persons",
                newName: "IX_Persons_IdCountrieId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_CityId",
                table: "Persons",
                newName: "IX_Persons_CountrieId");

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
    }
}
