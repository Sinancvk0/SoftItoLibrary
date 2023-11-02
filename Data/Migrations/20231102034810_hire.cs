using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class hire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodeId",
                table: "Hires");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Hires",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Hires");

            migrationBuilder.AddColumn<int>(
                name: "BarcodeId",
                table: "Hires",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
