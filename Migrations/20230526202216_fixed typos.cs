using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inlamningsuppgift_6.Migrations
{
    /// <inheritdoc />
    public partial class fixedtypos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkUrl",
                value: "/images/placeholders/fujifilmcamera270x295.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkUrl",
                value: "/images/placeholders/memorycardlexar270x295.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e1ad513-cac9-46ef-92e8-fb55b53f7387",
                column: "ConcurrencyStamp",
                value: "cbc98abd-6868-4c71-b931-b22f18d20543");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                column: "ConcurrencyStamp",
                value: "00a7105a-1e78-4d98-9f99-cc712009a246");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c59eef42-0d80-437c-a387-dfd0685f11e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "278c5cce-808f-402f-83d3-a20b1ba59457", "AQAAAAIAAYagAAAAEKWv4NGdkxLTrUSMcqtLFlYPeKk4+9cPQ6Rw6G5lSSQ/KnfV5saoS2VZLdDJuGUqlg==", "769c5b93-d394-4169-af0e-0c56df518488" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkUrl",
                value: "/images/placeholders/fujufilmcamera270x295.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkUrl",
                value: "/images/placeholders/memorycardlexar.jpg");
        }
    }
}
