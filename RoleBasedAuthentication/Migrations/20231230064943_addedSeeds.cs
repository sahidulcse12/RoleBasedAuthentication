using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoleBasedAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class addedSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bb68fb1-3416-4043-8b66-a6dc375fe985", "2", "User", "User" },
                    { "4c971afa-3b42-4b2e-ac86-e4e0e1a47d2b", "1", "Admin", "Admin" },
                    { "96214427-fe58-4504-893c-8a7aa74d372d", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb68fb1-3416-4043-8b66-a6dc375fe985");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c971afa-3b42-4b2e-ac86-e4e0e1a47d2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96214427-fe58-4504-893c-8a7aa74d372d");
        }
    }
}
