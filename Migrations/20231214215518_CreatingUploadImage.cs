using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class CreatingUploadImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarImgFileName",
                table: "CarroViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarImgFileName",
                table: "CarroViewModel");
        }
    }
}
