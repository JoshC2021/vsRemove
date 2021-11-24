using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAngualrTestJustin.Data.Migrations
{
    public partial class testingffffffff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garbage_AspNetUsers_UserId",
                table: "Garbage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Garbage",
                table: "Garbage");

            migrationBuilder.RenameTable(
                name: "Garbage",
                newName: "Garbo");

            migrationBuilder.RenameIndex(
                name: "IX_Garbage_UserId",
                table: "Garbo",
                newName: "IX_Garbo_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garbo",
                table: "Garbo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TestingGarbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestingGarbo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestingGarbo_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestingGarbo_UserId",
                table: "TestingGarbo",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garbo_AspNetUsers_UserId",
                table: "Garbo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garbo_AspNetUsers_UserId",
                table: "Garbo");

            migrationBuilder.DropTable(
                name: "TestingGarbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Garbo",
                table: "Garbo");

            migrationBuilder.RenameTable(
                name: "Garbo",
                newName: "Garbage");

            migrationBuilder.RenameIndex(
                name: "IX_Garbo_UserId",
                table: "Garbage",
                newName: "IX_Garbage_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garbage",
                table: "Garbage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Garbage_AspNetUsers_UserId",
                table: "Garbage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
