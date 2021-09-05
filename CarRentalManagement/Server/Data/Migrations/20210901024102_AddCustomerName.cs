using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddCustomerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "8956ddc9-e19f-4d85-a5a9-169099efb5ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "bae06ee8-5167-4336-81df-4d985554e86d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29dea4bd-50c8-4613-adc5-4a42babf5d64", "AQAAAAEAACcQAAAAEPhptxyWuI8qZI9Q2Ml+9oeg5UaQFR9t1mgzGmsbwvTyCZGbgg0Rzctlm0OGiUiPzg==", "0a8630e6-282d-411d-aaf4-d0d5e8599495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be869d32-0890-4a06-b4df-b2f39fcbbb17", "AQAAAAEAACcQAAAAEPxvoK8TIdfKCYWjylnsq+TjJAouAPHtKCIZM5kND5v0oxOoUHNLip6PGLXOfnpLCQ==", "1db832e3-1cae-4c28-9789-55aa8ab841a8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 857, DateTimeKind.Local).AddTicks(3191), new DateTime(2021, 8, 31, 21, 41, 0, 863, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 864, DateTimeKind.Local).AddTicks(1648), new DateTime(2021, 8, 31, 21, 41, 0, 864, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 866, DateTimeKind.Local).AddTicks(6288), new DateTime(2021, 8, 31, 21, 41, 0, 866, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 866, DateTimeKind.Local).AddTicks(7080), new DateTime(2021, 8, 31, 21, 41, 0, 866, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(4254), new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(4983), new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(5005), new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(5014), new DateTime(2021, 8, 31, 21, 41, 0, 867, DateTimeKind.Local).AddTicks(5019) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
