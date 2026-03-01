using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_learn.Migrations
{
    /// <inheritdoc />
    public partial class booksupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "editor",
                table: "books",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "is_original",
                table: "books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "language",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "translator",
                table: "books",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "editor",
                table: "books");

            migrationBuilder.DropColumn(
                name: "is_original",
                table: "books");

            migrationBuilder.DropColumn(
                name: "language",
                table: "books");

            migrationBuilder.DropColumn(
                name: "translator",
                table: "books");
        }
    }
}
