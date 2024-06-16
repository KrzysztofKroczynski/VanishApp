using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class final5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlannedDateEnd",
                table: "ItemStorages");

            migrationBuilder.RenameColumn(
                name: "PlannedDateStart",
                table: "ItemStorages",
                newName: "PlannedDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ItemStorages",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "ItemStorages",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "Discriminator", "TotalCapacity" },
                values: new object[] { 1, "123 Main St, Regular Town", "Regular", 100 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "Discriminator", "SecurityLevel", "TotalCapacity" },
                values: new object[] { 2, "456 Secure Blvd, Secure City", "HighSecurity", 4, 50 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "ClimateFee", "DailyFee", "Discriminator", "TotalCapacity" },
                values: new object[] { 3, "789 Climate Rd, Climate Town", 10m, 30m, "Climate", 75 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "Discriminator", "TotalCapacity" },
                values: new object[] { 4, "101 Capacity Dr, Tiny Town", "Regular", 1 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "Discriminator", "SecurityLevel", "TotalCapacity" },
                values: new object[] { 5, "202 Empty Ave, Null City", "HighSecurity", 2, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "PlannedDate",
                table: "ItemStorages",
                newName: "PlannedDateStart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ItemStorages",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "ItemStorages",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedDateEnd",
                table: "ItemStorages",
                type: "TEXT",
                nullable: true);
        }
    }
}
