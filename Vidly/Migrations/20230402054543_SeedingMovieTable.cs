using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using Vidly.Models;

#nullable disable

namespace Vidly.Migrations
{
    public partial class SeedingMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT[Vidly].[dbo].[Movies] OFF;");
            migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, GenreId, NumberInStock, ReleaseDate) VALUES ('Movie 1', '2023-04-05', 1, 10, '2023-04-05');");
            migrationBuilder.Sql("INSERT INTO [Vidly].[dbo].[Movies] ([Name], [DateAdded], [GenreId], [NumberInStock], [ReleaseDate])\r\nVALUES \r\n   ('The Shawshank Redemption', '1994-10-14', 1, 10, '1994-09-23'),\r\n   ('The Godfather', '1972-03-24', 2, 15, '1972-03-14'),\r\n   ('The Dark Knight', '2008-07-18', 3, 20, '2008-07-14');");
            migrationBuilder.Sql("SET IDENTITY_INSERT [Vidly].[dbo].[Movies] ON;");
            migrationBuilder.Sql("SET IDENTITY_INSERT[Vidly].[dbo].[Movies] ON;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
