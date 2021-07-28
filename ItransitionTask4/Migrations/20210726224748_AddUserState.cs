using Microsoft.EntityFrameworkCore.Migrations;

namespace ItransitionTask4.Migrations
{
    public partial class AddUserState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserState",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserState",
                table: "AspNetUsers");
        }
    }
}
