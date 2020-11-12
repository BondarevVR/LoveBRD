using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveBRD.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Apartment')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('House')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Room')");

            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Types WHERE Name IN('Apartment', 'House', 'Room')");
            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN('Feature1', 'Feature2', 'Feature3')");
        }
    }
}
