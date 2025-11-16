using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9531), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9544), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9547), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9547), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9684), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9685), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9686), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9687), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9747), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9748), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9749), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9750), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9751), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9752), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 11, 16, 22, 49, 47, 698, DateTimeKind.Local).AddTicks(9753), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
