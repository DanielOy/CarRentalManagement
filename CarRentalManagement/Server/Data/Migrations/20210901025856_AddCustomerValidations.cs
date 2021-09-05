using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddCustomerValidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
