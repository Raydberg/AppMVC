using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudMVC.Migrations
{
    /// <inheritdoc />
    public partial class Adddatatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreateTime", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 1, 16, 16, 4, 411, DateTimeKind.Local).AddTicks(5374), "juan.perez@example.com", "Juan Pérez", "123456789" },
                    { 2, new DateTime(2024, 11, 1, 16, 16, 4, 411, DateTimeKind.Local).AddTicks(5392), "maria.lopez@example.com", "María López", "987654321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
