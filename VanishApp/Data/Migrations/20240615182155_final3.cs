using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class final3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStorages_WarehouseId",
                table: "ItemStorages");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStorages_WarehouseId",
                table: "ItemStorages",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStorages_WarehouseId",
                table: "ItemStorages");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStorages_WarehouseId",
                table: "ItemStorages",
                column: "WarehouseId",
                unique: true);
        }
    }
}
