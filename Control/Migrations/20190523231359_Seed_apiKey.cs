using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Seed_apiKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO ApiKeys VALUES ('myapikey')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
