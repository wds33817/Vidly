using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    public partial class SeedingGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Customers ON");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            migrationBuilder.Sql("SET IDENTITY_INSERT Customers OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
