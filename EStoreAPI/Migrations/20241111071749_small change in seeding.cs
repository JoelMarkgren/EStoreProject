using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class smallchangeinseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Laptops/Lenovo7.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Laptops/Lenovo7.");
        }
    }
}
