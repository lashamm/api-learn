using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_learn.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    release_year = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<int>(type: "int", nullable: false),
                    pages = table.Column<int>(type: "int", nullable: false),
                    publication = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
