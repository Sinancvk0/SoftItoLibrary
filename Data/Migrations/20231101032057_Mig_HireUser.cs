using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_HireUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Hires_UserId",
                table: "Hires");

            migrationBuilder.CreateIndex(
                name: "IX_Hires_UserId",
                table: "Hires",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Hires_UserId",
                table: "Hires");

            migrationBuilder.CreateIndex(
                name: "IX_Hires_UserId",
                table: "Hires",
                column: "UserId");
        }
    }
}
