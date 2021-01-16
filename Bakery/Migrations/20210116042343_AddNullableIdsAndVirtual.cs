using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class AddNullableIdsAndVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorSweet_Flavors_FlavorId",
                table: "FlavorSweet");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorSweet_Sweets_SweetId",
                table: "FlavorSweet");

            migrationBuilder.AlterColumn<int>(
                name: "SweetId",
                table: "FlavorSweet",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FlavorId",
                table: "FlavorSweet",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorSweet_Flavors_FlavorId",
                table: "FlavorSweet",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorSweet_Sweets_SweetId",
                table: "FlavorSweet",
                column: "SweetId",
                principalTable: "Sweets",
                principalColumn: "SweetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorSweet_Flavors_FlavorId",
                table: "FlavorSweet");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorSweet_Sweets_SweetId",
                table: "FlavorSweet");

            migrationBuilder.AlterColumn<int>(
                name: "SweetId",
                table: "FlavorSweet",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlavorId",
                table: "FlavorSweet",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorSweet_Flavors_FlavorId",
                table: "FlavorSweet",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorSweet_Sweets_SweetId",
                table: "FlavorSweet",
                column: "SweetId",
                principalTable: "Sweets",
                principalColumn: "SweetId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
