using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 1, 20, 58, 42, 542, DateTimeKind.Local).AddTicks(9337), new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(5651), "Black", "System" },
                    { 2, "System", new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 8, 1, 20, 58, 42, 551, DateTimeKind.Local).AddTicks(7903), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 1, 20, 58, 42, 562, DateTimeKind.Local).AddTicks(9511), new DateTime(2021, 8, 1, 20, 58, 42, 562, DateTimeKind.Local).AddTicks(9588), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 8, 1, 20, 58, 42, 563, DateTimeKind.Local).AddTicks(283), new DateTime(2021, 8, 1, 20, 58, 42, 563, DateTimeKind.Local).AddTicks(299), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(2345), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(2429), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3297), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3317), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3615), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3633), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3642), new DateTime(2021, 8, 1, 20, 58, 42, 564, DateTimeKind.Local).AddTicks(3649), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
