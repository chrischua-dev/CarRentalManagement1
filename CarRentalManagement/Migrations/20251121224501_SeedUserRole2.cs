using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d367176-20f5-4adb-97c5-0ead14521d2f", null, "Administrator", "ADMINISTRATOR" },
                    { "aab7afd1-0f6d-4d89-a019-f63cc85fef86", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6d7659b-41aa-4bd6-bbe4-568adef28cd4", 0, "83a7529a-6b95-476e-ad15-316be66c2a27", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKULjem6sjuIEdQHcBxjgytSIIF8YGnp9KBQPuCtEQ6xbaoJ3Sm7ygJNeZfqb/3Tig==", null, false, "3ec2c502-5722-40ca-a068-2f945af7e5b6", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(973), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(988), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1127), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1129), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1196), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1198), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1200), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1201), new DateTime(2025, 11, 22, 6, 45, 1, 323, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d367176-20f5-4adb-97c5-0ead14521d2f", "f6d7659b-41aa-4bd6-bbe4-568adef28cd4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aab7afd1-0f6d-4d89-a019-f63cc85fef86");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d367176-20f5-4adb-97c5-0ead14521d2f", "f6d7659b-41aa-4bd6-bbe4-568adef28cd4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d367176-20f5-4adb-97c5-0ead14521d2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6d7659b-41aa-4bd6-bbe4-568adef28cd4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2695), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2708), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2909), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2995), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(3001), new DateTime(2025, 11, 22, 6, 40, 56, 958, DateTimeKind.Local).AddTicks(3001) });
        }
    }
}
