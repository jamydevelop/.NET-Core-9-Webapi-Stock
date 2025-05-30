using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Test01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4afe5d52-596d-468a-bba7-be3ca28e7061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96d2fbe-cd91-40b2-ab25-ea2bdd1cf9a1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aadfef44-311f-42b8-bbf3-8f7ff1482d94", null, "User", "USER" },
                    { "c483ed3b-95a9-42f8-b60d-a602f81ee107", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aadfef44-311f-42b8-bbf3-8f7ff1482d94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c483ed3b-95a9-42f8-b60d-a602f81ee107");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4afe5d52-596d-468a-bba7-be3ca28e7061", null, "User", "USER" },
                    { "d96d2fbe-cd91-40b2-ab25-ea2bdd1cf9a1", null, "Admin", "ADMIN" }
                });
        }
    }
}
