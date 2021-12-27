using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectList_Final.Migrations
{
    public partial class Second_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestourantComments_RestourantComments_RParentCommentId",
                table: "RestourantComments");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropIndex(
                name: "IX_RestourantComments_RParentCommentId",
                table: "RestourantComments");

            migrationBuilder.DropColumn(
                name: "RParentCommentId",
                table: "RestourantComments");

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuToRestourants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingrediend = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    RestourantId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuToRestourants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuToRestourants_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuToRestourants_Restourants_RestourantId",
                        column: x => x.RestourantId,
                        principalTable: "Restourants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuToRestourants_MenuId",
                table: "MenuToRestourants",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuToRestourants_RestourantId",
                table: "MenuToRestourants",
                column: "RestourantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuToRestourants");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "RParentCommentId",
                table: "RestourantComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingrediend = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    RestourantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pricings_Restourants_RestourantId",
                        column: x => x.RestourantId,
                        principalTable: "Restourants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestourantComments_RParentCommentId",
                table: "RestourantComments",
                column: "RParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pricings_RestourantId",
                table: "Pricings",
                column: "RestourantId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestourantComments_RestourantComments_RParentCommentId",
                table: "RestourantComments",
                column: "RParentCommentId",
                principalTable: "RestourantComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
