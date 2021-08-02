using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cac43f1d-f7bb-4448-baaf-1addd431ccbbf", 0, "44d88c56-f736-44bd-9a05-6803502fefce", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEET/sgxrj4s53XW23qRm4z7UGX9YyrGG2lNX8FwjvSt3JDZP0zoZFZszDBHVanqC7g==", null, false, "fb4be2d4-3a0d-435b-a7e4-078c899561d9", false, "admin@localhost.com" },
                    { "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf", 0, "ed207e1b-47dc-44c4-8b66-608c35dfcd07", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEG37IibJq0MyVMWrMBNXm7iy+Dqo5I9ns4n1DqP/vsMnR7BxjjRhrnU9sy+AMI8oQg==", null, false, "3d9bd3e2-3fe4-425f-aa6a-c6f390bd4980", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf", "cac43f1d-f7bb-4448-baaf-1addd431ccbbf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1addd431ccbbf", "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf", "cac43f1d-f7bb-4448-baaf-1addd431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1addd431ccbbf", "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "0359dd7e-632d-4a10-a74e-620ccef8d336");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "d3b9e7e3-f955-4a72-8d2f-b3fcb82888dd");

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
    }
}
