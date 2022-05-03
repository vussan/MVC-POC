using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { (byte)1, "Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedBy", "Email", "FirstName", "IsActive", "LastName", "Mobile", "ModifiedBy", "Password", "RoleId", "Username" },
                values: new object[] { new Guid("f3521872-12c1-4eb4-a0f4-3e3d000ba9b7"), new Guid("00000000-0000-0000-0000-000000000000"), "bhusan@noveltytechnology.com", "Bhusan", false, "Bhele", null, null, "P@ssw0rd", (byte)1, "vussan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f3521872-12c1-4eb4-a0f4-3e3d000ba9b7"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: (byte)1);
        }
    }
}
