using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoleBasedAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class addedStaffTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783a7224-8789-451c-92ad-c6bfa46df173");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80dbb559-afa0-472f-adec-902da1ea5d84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b720cfdd-3826-4a54-a0a9-880a9ec9b774");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faf3e1ab-a730-4d3f-a6d8-f5bff1605b60");

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56704c41-eed3-4331-8129-8af7e6ed89be", "2", "Staff", "Staff" },
                    { "61ed49b8-00df-40f1-b487-957b862df3e8", "3", "Manager", "Manager" },
                    { "86b45b0e-e443-4ede-9cfd-fc3c44106aaf", "1", "Admin", "Admin" },
                    { "f8385729-bdda-4f72-acc8-e9e0ec13d838", "4", "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56704c41-eed3-4331-8129-8af7e6ed89be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ed49b8-00df-40f1-b487-957b862df3e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b45b0e-e443-4ede-9cfd-fc3c44106aaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8385729-bdda-4f72-acc8-e9e0ec13d838");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "783a7224-8789-451c-92ad-c6bfa46df173", "2", "Staff", "Staff" },
                    { "80dbb559-afa0-472f-adec-902da1ea5d84", "1", "Admin", "Admin" },
                    { "b720cfdd-3826-4a54-a0a9-880a9ec9b774", "3", "Manager", "Manager" },
                    { "faf3e1ab-a730-4d3f-a6d8-f5bff1605b60", "4", "User", "User" }
                });
        }
    }
}
