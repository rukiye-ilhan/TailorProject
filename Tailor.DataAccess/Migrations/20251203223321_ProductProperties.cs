using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tailor.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties",
                column: "ProductId",
                unique: true);
        }
    }
}
