using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class fixingDataSeending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "CarImgFileName",
                value: "skylinevelozesefuriosos.jpeg");

            migrationBuilder.UpdateData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarImgFileName",
                value: "toyota-supra.jpg");

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2023, 12, 16, 0, 37, 47, 839, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(2023, 12, 16, 0, 37, 47, 839, DateTimeKind.Local).AddTicks(2758));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "CarImgFileName",
                value: "skylinevelozesefuriosos");

            migrationBuilder.UpdateData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarImgFileName",
                value: "toyota-supra");

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2023, 12, 16, 0, 27, 39, 604, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(2023, 12, 16, 0, 27, 39, 604, DateTimeKind.Local).AddTicks(1442));
        }
    }
}
