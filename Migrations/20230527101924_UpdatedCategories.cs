using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inlamningsuppgift_6.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e1ad513-cac9-46ef-92e8-fb55b53f7387",
                column: "ConcurrencyStamp",
                value: "c277299e-2963-4d18-84c4-05f1740cf2cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                column: "ConcurrencyStamp",
                value: "dfa99927-9b3f-4b28-9cc3-a3ccf0bb1d73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea822dcd-795b-443c-82d4-e69ffbe759b1", "AQAAAAIAAYagAAAAEGy9Mzsg+gq9/JcfkMtWaL+4c8TYIDySwLgMjzZIZr+88HWr9zb85jGvqXO5nOS42A==", "f9b4fc7d-ef80-4fad-9076-4715d6a8a9a5" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 8 },
                    { 3, 12 },
                    { 1, 13 },
                    { 3, 14 },
                    { 1, 15 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e1ad513-cac9-46ef-92e8-fb55b53f7387",
                column: "ConcurrencyStamp",
                value: "747177d7-1209-42f6-8645-8c27e462b178");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                column: "ConcurrencyStamp",
                value: "9986cf7b-ff36-41d9-a512-abf964740ef2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7486b41c-ec6b-48d1-a3ff-39c583fe6fa7", "AQAAAAIAAYagAAAAEBtmc0FVLM0EVlATG3RPXoSQhS9vefHE+rSmdr4mfumqXWkhQzsJ7Y9mP4k/8FExGQ==", "c95b56b5-22ef-43b0-90fd-fef01d423cc2" });
        }
    }
}
