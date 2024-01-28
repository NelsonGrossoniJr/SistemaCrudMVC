using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace New_ATCSharp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingPiloto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PilotoViewModel",
                columns: new[] { "Id", "CorridasGanhas", "Equipe", "Idade", "Nome" },
                values: new object[,]
                {
                    { 1, 100, "velozes e furiosos", 52, "Dominic Toreto" },
                    { 2, 85, "velozes e furiosos", 43, "Brian O´Conner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PilotoViewModel",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
