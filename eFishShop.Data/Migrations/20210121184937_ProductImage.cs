using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eFishShop.Data.Migrations
{
    public partial class ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 21, 17, 45, 27, 213, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 21, 17, 45, 27, 213, DateTimeKind.Local).AddTicks(1922),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e9c038b-8bc3-4419-9acf-6424dd3b78d5"),
                column: "ConcurrencyStamp",
                value: "264be4ec-27c0-45d4-866b-065e1d6592eb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c281d40-55f7-44dd-86e8-58d9ef485428"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdaddde3-0544-4f0c-a822-c58012171c09", "AQAAAAEAACcQAAAAEK0ByG4/VafBd2zPh+Nbim/11XdIgMtLDr/ahHDO5XyH4RUGqsPGoyhzCmUic1qu9Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 21, 17, 45, 27, 233, DateTimeKind.Local).AddTicks(3816));
        }
    }
}
