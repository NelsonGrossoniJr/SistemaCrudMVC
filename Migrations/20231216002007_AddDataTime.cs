using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class AddDataTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "PilotoViewModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "PilotoViewModel");
        }
    }
}
