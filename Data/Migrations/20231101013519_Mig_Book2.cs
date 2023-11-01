using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Book2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBarcode_Books_BookId",
                table: "BookBarcode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookBarcode",
                table: "BookBarcode");

            migrationBuilder.RenameTable(
                name: "BookBarcode",
                newName: "BookBarcodes");

            migrationBuilder.RenameIndex(
                name: "IX_BookBarcode_BookId",
                table: "BookBarcodes",
                newName: "IX_BookBarcodes_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookBarcodes",
                table: "BookBarcodes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Hires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hires", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookBarcodes_Books_BookId",
                table: "BookBarcodes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBarcodes_Books_BookId",
                table: "BookBarcodes");

            migrationBuilder.DropTable(
                name: "Hires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookBarcodes",
                table: "BookBarcodes");

            migrationBuilder.RenameTable(
                name: "BookBarcodes",
                newName: "BookBarcode");

            migrationBuilder.RenameIndex(
                name: "IX_BookBarcodes_BookId",
                table: "BookBarcode",
                newName: "IX_BookBarcode_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookBarcode",
                table: "BookBarcode",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBarcode_Books_BookId",
                table: "BookBarcode",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
