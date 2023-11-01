using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adrresses_Adrresses_AdrressId",
                table: "Adrresses");

            migrationBuilder.DropIndex(
                name: "IX_Adrresses_AdrressId",
                table: "Adrresses");

            migrationBuilder.DropColumn(
                name: "AdrressId",
                table: "Adrresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdrressId",
                table: "Adrresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adrresses_AdrressId",
                table: "Adrresses",
                column: "AdrressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adrresses_Adrresses_AdrressId",
                table: "Adrresses",
                column: "AdrressId",
                principalTable: "Adrresses",
                principalColumn: "Id");
        }
    }
}
