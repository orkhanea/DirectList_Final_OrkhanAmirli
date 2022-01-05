using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectList_Final.Migrations
{
    public partial class Editing_somethings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restourants_RestourantMenagers_RestourantMenagerId",
                table: "Restourants");

            migrationBuilder.DropTable(
                name: "RestourantMenagers");

            migrationBuilder.DropIndex(
                name: "IX_Restourants_RestourantMenagerId",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "RestourantMenagerId",
                table: "Restourants");

            migrationBuilder.AddColumn<string>(
                name: "ManagerEmail",
                table: "Restourants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerImage",
                table: "Restourants",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerName",
                table: "Restourants",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerPhone",
                table: "Restourants",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerSurName",
                table: "Restourants",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerWebSite",
                table: "Restourants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerEmail",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "ManagerImage",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "ManagerName",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "ManagerPhone",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "ManagerSurName",
                table: "Restourants");

            migrationBuilder.DropColumn(
                name: "ManagerWebSite",
                table: "Restourants");

            migrationBuilder.AddColumn<int>(
                name: "RestourantMenagerId",
                table: "Restourants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RestourantMenagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RestourantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestourantMenagers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restourants_RestourantMenagerId",
                table: "Restourants",
                column: "RestourantMenagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restourants_RestourantMenagers_RestourantMenagerId",
                table: "Restourants",
                column: "RestourantMenagerId",
                principalTable: "RestourantMenagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
