using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Clients_ClientId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ClientId1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Items",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ClientId",
                table: "Items",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Clients_ClientId",
                table: "Items",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Clients_ClientId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ClientId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ClientId1",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ClientId1",
                table: "Items",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Clients_ClientId1",
                table: "Items",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
