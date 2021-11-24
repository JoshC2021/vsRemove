using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAngualrTestJustin.Data.Migrations
{
    public partial class breaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Brakes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brakes_ApplicationUserId",
                table: "Brakes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brakes_AspNetUsers_ApplicationUserId",
                table: "Brakes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brakes_AspNetUsers_ApplicationUserId",
                table: "Brakes");

            migrationBuilder.DropIndex(
                name: "IX_Brakes_ApplicationUserId",
                table: "Brakes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Brakes");
        }
    }
}
