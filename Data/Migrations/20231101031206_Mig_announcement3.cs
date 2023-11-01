using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_announcement3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HireUser");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Hires");

            migrationBuilder.AddColumn<int>(
                name: "HireId",
                table: "BookBarcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hires_UserId",
                table: "Hires",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBarcodes_HireId",
                table: "BookBarcodes",
                column: "HireId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookBarcodes_Hires_HireId",
                table: "BookBarcodes",
                column: "HireId",
                principalTable: "Hires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hires_Users_UserId",
                table: "Hires",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBarcodes_Hires_HireId",
                table: "BookBarcodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Hires_Users_UserId",
                table: "Hires");

            migrationBuilder.DropIndex(
                name: "IX_Hires_UserId",
                table: "Hires");

            migrationBuilder.DropIndex(
                name: "IX_BookBarcodes_HireId",
                table: "BookBarcodes");

            migrationBuilder.DropColumn(
                name: "HireId",
                table: "BookBarcodes");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Hires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HireUser",
                columns: table => new
                {
                    HiresId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HireUser", x => new { x.HiresId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_HireUser_Hires_HiresId",
                        column: x => x.HiresId,
                        principalTable: "Hires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HireUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HireUser_UsersId",
                table: "HireUser",
                column: "UsersId");
        }
    }
}
