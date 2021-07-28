using Microsoft.EntityFrameworkCore.Migrations;

namespace ItransitionTask4.Migrations
{
    public partial class DeleteUserState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserState",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserState",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
