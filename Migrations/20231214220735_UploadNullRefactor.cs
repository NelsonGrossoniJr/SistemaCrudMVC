using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class UploadNullRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CarImgFileName",
                table: "CarroViewModel",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CarImgFileName",
                table: "CarroViewModel",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }
    }
}
