using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class wronglynamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/videos/LumaAI.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/videos/LumaAI.mp4.mp4");
        }
    }
}
