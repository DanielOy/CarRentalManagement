using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "6a9b3db0-2f1b-4180-b918-a3ef39ecc745");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e5309ddd-b44e-4b3a-8027-982012c59117");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78f2e9b4-0616-4d59-b1db-91f235bbae6c", "AQAAAAEAACcQAAAAEPzDI3dZpNC0CTJnPtM/iTqlhgeC50pFPbiMQiPsJuygxc5C1iS+EiaY6LTG9gzKtg==", "8383db7a-e257-469e-b354-197f480f8648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e233272f-f444-4767-809a-67611c149c68", "AQAAAAEAACcQAAAAEOspW8bFFR/ZTcCm4gcFtYatvJKF45nIsnsgkXYZGKL/qcNwCTdUs9gnI+gLsNvYLg==", "9f4d2fa6-d8c8-4d58-a0e3-6fcc02a114f7" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 438, DateTimeKind.Local).AddTicks(3509), new DateTime(2021, 9, 7, 16, 52, 14, 444, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 445, DateTimeKind.Local).AddTicks(298), new DateTime(2021, 9, 7, 16, 52, 14, 445, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 447, DateTimeKind.Local).AddTicks(3382), new DateTime(2021, 9, 7, 16, 52, 14, 447, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 447, DateTimeKind.Local).AddTicks(4082), new DateTime(2021, 9, 7, 16, 52, 14, 447, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(835), new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1508), new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1529), new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1539), new DateTime(2021, 9, 7, 16, 52, 14, 448, DateTimeKind.Local).AddTicks(1543) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "04d0d698-90a0-4781-ac91-7447a81a05e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a6e-f7bb-4445-baaf-1addd431ccbbf",
                column: "ConcurrencyStamp",
                value: "d079f2a3-cd16-4b6a-96cc-f33f3cf3695a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "800a0028-adbb-47de-9ca6-81d91d1b4a43", "AQAAAAEAACcQAAAAEP/4g0f4ZeIvC8gwME+zqsXEZn6hgweHjYB874+yf8Gdmk5SiYu6nm4JQEMRlDIqhQ==", "1f7b404f-ee93-4f80-902f-978b1e5a977a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dqa43f1d-f7bb-4448-baaf-1addd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9520d5c4-a105-491e-b657-056dde65c267", "AQAAAAEAACcQAAAAEJgno5+MBN2sDdD0yt2H2QLRuFe4nNCsPezsB64xw/HWWA5Ug5VTCREfP7UYjhW0QQ==", "545533ad-a723-4e6c-a55a-5987c2880605" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 137, DateTimeKind.Local).AddTicks(576), new DateTime(2021, 8, 31, 21, 58, 55, 143, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 143, DateTimeKind.Local).AddTicks(9711), new DateTime(2021, 8, 31, 21, 58, 55, 143, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 146, DateTimeKind.Local).AddTicks(7371), new DateTime(2021, 8, 31, 21, 58, 55, 146, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 146, DateTimeKind.Local).AddTicks(8074), new DateTime(2021, 8, 31, 21, 58, 55, 146, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(4142), new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5005), new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5028), new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5038), new DateTime(2021, 8, 31, 21, 58, 55, 147, DateTimeKind.Local).AddTicks(5042) });
        }
    }
}
