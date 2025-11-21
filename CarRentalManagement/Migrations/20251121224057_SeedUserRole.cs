using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4027), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4043), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4202), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4269), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4271), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 11, 22, 6, 20, 18, 293, DateTimeKind.Local).AddTicks(4273) });
        }
    }
}
