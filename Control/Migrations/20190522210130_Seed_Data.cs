using Control.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Admins VALUES ( 'Admin', 'Admin', 'OpenDreamsAdmin', 'Admin@gmail.com')");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
