using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Order1" });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Order2" });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Order3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
