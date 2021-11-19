using Microsoft.EntityFrameworkCore.Migrations;

namespace Moq.Demo.Migrations
{
    public partial class tableupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "designation", "name" },
                values: new object[] { 1, "manager", "Pulkit" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "designation", "name" },
                values: new object[] { 2, "Developer", "thepulkit" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "designation", "name" },
                values: new object[] { 3, "tester", "Pulkit2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
