using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConceptOBack.Migrations
{
    /// <inheritdoc />
    public partial class AddedPicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackPictureUrl",
                table: "Settings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconPictureUrl",
                table: "Settings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Characters",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackPictureUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "IconPictureUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Characters");
        }
    }
}
