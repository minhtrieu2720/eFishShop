using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eFishShop.Data.Migrations
{
    public partial class changefile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5"),
                column: "ConcurrencyStamp",
                value: "fe4f58fb-1740-4069-98df-f2a36611dba0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40734f57-62e7-4382-b5e4-b5c31c8e1753", "AQAAAAEAACcQAAAAEBh1CeZ8ZmetFJg//9QRRzIGVcQyg7FZ47+JKPn3C3Cj2GoVkxUs2Rq1EaqNZ21SEw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 22, 2, 26, 58, 566, DateTimeKind.Local).AddTicks(5888));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5"),
                column: "ConcurrencyStamp",
                value: "cf31a2be-bf5e-41fa-a6da-2e43b139e12e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12b3c9d9-0c23-49dd-a044-5a8f0af5cdd8", "AQAAAAEAACcQAAAAEBazEF26Wc38H3tnFuKHK/jJMqx3lb1lj784pNqRXmfRg+QboxymcmsMykpK2mVsXA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 22, 1, 49, 36, 943, DateTimeKind.Local).AddTicks(3671));
        }
    }
}
