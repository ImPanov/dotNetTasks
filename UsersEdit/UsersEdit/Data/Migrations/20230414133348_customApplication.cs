using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersEdit.Data.Migrations
{
    public partial class customApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvatarUrl",
                table: "AspNetUsers",
                newName: "AvatarsImg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvatarsImg",
                table: "AspNetUsers",
                newName: "AvatarUrl");
        }
    }
}
