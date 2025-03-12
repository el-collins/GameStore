using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6920), "Action" },
                    { 2, new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6939), "Adventure" },
                    { 3, new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6942), "RPG" },
                    { 4, new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6943), "Simulation" },
                    { 5, new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6944), "Strategy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
