using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddLookUps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "AK", "Alaska", 0 },
                    { "AZ", "Arizona", 0 },
                    { "AR", "Arkansas", 0 },
                    { "CA", "California", 0 },
                    { "CO", "Colorado", 0 },
                    { "CT", "Connecticut", 0 },
                    { "DE", "Delaware", 0 },
                    { "DC", "District of Columbia", 0 },
                    { "FL", "Florida", 0 },
                    { "GA", "Georgia", 0 },
                    { "ID", "Idaho", 0 },
                    { "USA", "United States of America", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AK");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AR");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AZ");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CO");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CT");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "DC");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "FL");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "USA");
        }
    }
}
