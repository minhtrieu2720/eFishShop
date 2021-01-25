using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eFishShop.Data.Migrations
{
    public partial class SeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 21, 17, 45, 27, 213, DateTimeKind.Local).AddTicks(1922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 21, 17, 38, 2, 549, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5"), "264be4ec-27c0-45d4-866b-065e1d6592eb", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"), new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"), 0, "fdaddde3-0544-4f0c-a822-c58012171c09", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenminhtrieu201198@gmail.com", true, "Nguyen", "Trieu", false, null, "nguyenminhtrieu201198@gmail.com", "admin", "AQAAAAEAACcQAAAAEK0ByG4/VafBd2zPh+Nbim/11XdIgMtLDr/ahHDO5XyH4RUGqsPGoyhzCmUic1qu9Q==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 21, 17, 45, 27, 233, DateTimeKind.Local).AddTicks(3816));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"), new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 21, 17, 38, 2, 549, DateTimeKind.Local).AddTicks(8608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 21, 17, 45, 27, 213, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 21, 17, 38, 2, 569, DateTimeKind.Local).AddTicks(4653));
        }
    }
}
