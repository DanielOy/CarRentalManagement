using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class DateOutNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "6c0699da-c9f8-4353-8185-64443c920ea5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e175260b-d3f5-45e8-ac58-29e9908796ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1abb0a5a-1b3c-499a-b5ea-4c4b69692350", "AQAAAAEAACcQAAAAENIj0hprlIhVwju3ngfDEqeiCv+PuVbCGl9gPlcmjtoECbxFSILd6LKixH9hBzK50Q==", "46cd3e2a-6ab4-49ba-b969-473d8441e763" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecaf1a2d-eefa-441f-b980-b022c5da6310", "AQAAAAEAACcQAAAAEPmI0p531OZHHajmi1zqDWNwdaQKhHAS/8A3z4cnmc4bfWCpgz4AeBsR3opxR9DDMg==", "22dbaca8-d39c-4da9-bb4b-622ffb322b45" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 765, DateTimeKind.Local).AddTicks(7671), new DateTime(2021, 8, 31, 16, 10, 27, 774, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 775, DateTimeKind.Local).AddTicks(1798), new DateTime(2021, 8, 31, 16, 10, 27, 775, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 779, DateTimeKind.Local).AddTicks(7083), new DateTime(2021, 8, 31, 16, 10, 27, 779, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 779, DateTimeKind.Local).AddTicks(8362), new DateTime(2021, 8, 31, 16, 10, 27, 779, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(1957), new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3150), new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3198), new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3243), new DateTime(2021, 8, 31, 16, 10, 27, 781, DateTimeKind.Local).AddTicks(3252) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "2a301af3-c4d2-44f1-ade5-80abe47543ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "2251bcd8-ee12-49ca-bf67-2a1d98e28b93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44d88c56-f736-44bd-9a05-6803502fefce", "AQAAAAEAACcQAAAAEET/sgxrj4s53XW23qRm4z7UGX9YyrGG2lNX8FwjvSt3JDZP0zoZFZszDBHVanqC7g==", "fb4be2d4-3a0d-435b-a7e4-078c899561d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed207e1b-47dc-44c4-8b66-608c35dfcd07", "AQAAAAEAACcQAAAAEG37IibJq0MyVMWrMBNXm7iy+Dqo5I9ns4n1DqP/vsMnR7BxjjRhrnU9sy+AMI8oQg==", "3d9bd3e2-3fe4-425f-aa6a-c6f390bd4980" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 46, DateTimeKind.Local).AddTicks(1717), new DateTime(2021, 8, 1, 22, 44, 38, 55, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 55, DateTimeKind.Local).AddTicks(2306), new DateTime(2021, 8, 1, 22, 44, 38, 55, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 57, DateTimeKind.Local).AddTicks(5820), new DateTime(2021, 8, 1, 22, 44, 38, 57, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 57, DateTimeKind.Local).AddTicks(6550), new DateTime(2021, 8, 1, 22, 44, 38, 57, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(7578), new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8398), new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8423), new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8434), new DateTime(2021, 8, 1, 22, 44, 38, 58, DateTimeKind.Local).AddTicks(8438) });
        }
    }
}
