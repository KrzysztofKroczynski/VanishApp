using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class final8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsurancePolicies",
                columns: new[] { "Id", "Fee", "IncludesHazardItems", "MaxPayout", "Name" },
                values: new object[,]
                {
                    { 1, 100m, false, 10000m, "Basic Coverage" },
                    { 2, 250m, false, 50000m, "Standard Coverage" },
                    { 3, 500m, false, 100000m, "Premium Coverage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsurancePolicies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsurancePolicies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsurancePolicies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
