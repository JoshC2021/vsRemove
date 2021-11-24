using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAngualrTestJustin.Data.Migrations
{
    public partial class testingfffffff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garbo_AspNetUsers_UserId",
                table: "Garbo");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Brakes");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "DisDead");

            migrationBuilder.DropTable(
                name: "Eyes");

            migrationBuilder.DropTable(
                name: "ForeignTester");

            migrationBuilder.DropTable(
                name: "Fruit");

            migrationBuilder.DropTable(
                name: "Peeps");

            migrationBuilder.DropTable(
                name: "Turtle");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_AspNetUsers_ApplicationUserFK",
                        column: x => x.ApplicationUserFK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brakes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisDead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisDead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisDead_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eyes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eyes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eyes_AspNetUsers_ApplicationUserFK",
                        column: x => x.ApplicationUserFK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForeignTester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignTester", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForeignTester_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fruit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fruit_AspNetUsers_ApplicationUserFK",
                        column: x => x.ApplicationUserFK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peeps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turtle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turtle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turtle_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_ApplicationUserFK",
                table: "Actor",
                column: "ApplicationUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Brakes_ApplicationUserId",
                table: "Brakes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ApplicationUserId",
                table: "Cars",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DisDead_ApplicationUserId",
                table: "DisDead",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Eyes_ApplicationUserFK",
                table: "Eyes",
                column: "ApplicationUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignTester_applicationUserId",
                table: "ForeignTester",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fruit_ApplicationUserFK",
                table: "Fruit",
                column: "ApplicationUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Turtle_ApplicationUserId",
                table: "Turtle",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garbo_AspNetUsers_UserId",
                table: "Garbo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
