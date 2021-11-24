using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAngualrTestJustin.Data.Migrations
{
    public partial class testForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppicationUser",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppicationUser",
                table: "AspNetUsers",
                column: "AppicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Class_AppicationUser",
                table: "AspNetUsers",
                column: "AppicationUser",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Class_AppicationUser",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppicationUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppicationUser",
                table: "AspNetUsers");
        }
    }
}
