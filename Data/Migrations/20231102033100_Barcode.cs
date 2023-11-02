using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Barcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBarcodes_Hires_HireId",
                table: "BookBarcodes");

            migrationBuilder.DropIndex(
                name: "IX_BookBarcodes_HireId",
                table: "BookBarcodes");

            migrationBuilder.DropColumn(
                name: "HireId",
                table: "BookBarcodes");

            migrationBuilder.CreateTable(
                name: "BookBarcodeHire",
                columns: table => new
                {
                    BookBarcodesId = table.Column<int>(type: "int", nullable: false),
                    HireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBarcodeHire", x => new { x.BookBarcodesId, x.HireId });
                    table.ForeignKey(
                        name: "FK_BookBarcodeHire_BookBarcodes_BookBarcodesId",
                        column: x => x.BookBarcodesId,
                        principalTable: "BookBarcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBarcodeHire_Hires_HireId",
                        column: x => x.HireId,
                        principalTable: "Hires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBarcodeHire_HireId",
                table: "BookBarcodeHire",
                column: "HireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBarcodeHire");

            migrationBuilder.AddColumn<int>(
                name: "HireId",
                table: "BookBarcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
