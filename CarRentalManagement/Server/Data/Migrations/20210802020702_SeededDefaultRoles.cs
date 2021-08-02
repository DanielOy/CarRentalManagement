using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1addd431ccbbf", "0359dd7e-632d-4a10-a74e-620ccef8d336", "User", "USER" },
                    { "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf", "d3b9e7e3-f955-4a72-8d2f-b3fcb82888dd", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 229, DateTimeKind.Local).AddTicks(1035), new DateTime(2021, 8, 1, 21, 7, 1, 237, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 238, DateTimeKind.Local).AddTicks(2146), new DateTime(2021, 8, 1, 21, 7, 1, 238, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 241, DateTimeKind.Local).AddTicks(9252), new DateTime(2021, 8, 1, 21, 7, 1, 241, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 242, DateTimeKind.Local).AddTicks(526), new DateTime(2021, 8, 1, 21, 7, 1, 242, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(6007), new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7190), new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7229), new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7246), new DateTime(2021, 8, 1, 21, 7, 1, 245, DateTimeKind.Local).AddTicks(7252) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 542, DateTimeKind.Local).AddTicks(9337), new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 562, DateTimeKind.Local).AddTicks(9511), new DateTime(2021, 8, 1, 20, 58, 42, 562, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 563, DateTimeKind.Local).AddTicks(283), new DateTime(2021, 8, 1, 20, 58, 42, 563, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(2345), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3297), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3615), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3642), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3649) });
        }
    }
}
