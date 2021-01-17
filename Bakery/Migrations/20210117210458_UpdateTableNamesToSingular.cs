using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class UpdateTableNamesToSingular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Sweets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sweets_UserId",
                table: "Sweets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sweets_AspNetUsers_UserId",
                table: "Sweets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sweets_AspNetUsers_UserId",
                table: "Sweets");

            migrationBuilder.DropIndex(
                name: "IX_Sweets_UserId",
                table: "Sweets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sweets");
        }
    }
}
