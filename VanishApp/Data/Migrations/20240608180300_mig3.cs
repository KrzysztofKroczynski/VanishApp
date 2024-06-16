using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Disciminator",
                table: "Warehouses",
                newName: "Discriminator");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Items",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FireHazard",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HealthHazard",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstabilityHazard",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InsurancePolicies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FireHazard",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HealthHazard",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "InstabilityHazard",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InsurancePolicies");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Warehouses",
                newName: "Disciminator");
        }
    }
}
