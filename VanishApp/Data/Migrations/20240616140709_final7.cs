using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanishApp.Migrations
{
    /// <inheritdoc />
    public partial class final7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorages_InsurancePolicies_InsurancePolicyId",
                table: "ItemStorages");

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePolicyId",
                table: "ItemStorages",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorages_InsurancePolicies_InsurancePolicyId",
                table: "ItemStorages",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorages_InsurancePolicies_InsurancePolicyId",
                table: "ItemStorages");

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePolicyId",
                table: "ItemStorages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorages_InsurancePolicies_InsurancePolicyId",
                table: "ItemStorages",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
