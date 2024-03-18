using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookstoreChallenge.sql.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "Price", "Publisher", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("18059d06-36e7-4d05-9640-acb210583c08"), "Name Surname", "Adventure", "123456-789101112-13141516-1718192021", 32.880000000000003, "Publisher Test", false, "Title Teste 3" },
                    { new Guid("6789bb44-7367-4c69-9972-61f906aabb5d"), "Name Surname", "Drama", "123456-789101112-13141516-1718192021", 19.120000000000001, "Publisher Test", true, "Title Teste 2" },
                    { new Guid("a6bae431-0b44-4c4f-bdc6-e571045b5e05"), "Name Surname", "Fantasy", "123456-789101112-13141516-1718192021", 24.550000000000001, "Publisher Test", true, "Title Teste 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
