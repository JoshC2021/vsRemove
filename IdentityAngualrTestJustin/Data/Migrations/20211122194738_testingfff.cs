using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAngualrTestJustin.Data.Migrations
{
    public partial class testingfff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserFK",
                table: "Eyes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eyes_ApplicationUserFK",
                table: "Eyes",
                column: "ApplicationUserFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Eyes_AspNetUsers_ApplicationUserFK",
                table: "Eyes",
                column: "ApplicationUserFK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eyes_AspNetUsers_ApplicationUserFK",
                table: "Eyes");

            migrationBuilder.DropIndex(
                name: "IX_Eyes_ApplicationUserFK",
                table: "Eyes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserFK",
                table: "Eyes");
        }
    }
}
