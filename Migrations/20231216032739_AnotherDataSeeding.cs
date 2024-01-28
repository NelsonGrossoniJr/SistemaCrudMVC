using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class AnotherDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarroViewModel",
                columns: new[] { "Id", "CarImgFileName", "Cor", "Marca", "Modelo", "Potencia" },
                values: new object[,]
                {
                    { 1, "skylinevelozesefuriosos", "Azul e prata", "Nissan", "Skyline", 100 },
                    { 2, "toyota-supra", "Laranja", "Toyota", "Supra", 200 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarroViewModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2023, 12, 15, 21, 36, 43, 687, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(2023, 12, 15, 21, 36, 43, 687, DateTimeKind.Local).AddTicks(9245));
        }
    }
}
