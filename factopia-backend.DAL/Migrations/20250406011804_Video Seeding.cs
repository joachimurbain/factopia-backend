using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VideoSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "/videos/1_A.mp4");

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "FileType", "IsCorrect", "Name", "Path", "QuestionId" },
                values: new object[,]
                {
                    { 2, "Image", false, "A_1.mp4", "/videos/1_B.mp4", 1 },
                    { 3, "Image", false, "A_1.mp4", "/videos/2_A.mp4", 1 },
                    { 4, "Image", false, "A_1.mp4", "/videos/2_B.mp4", 1 },
                    { 5, "Image", false, "A_1.mp4", "/videos/3_A.mp4", 1 },
                    { 6, "Image", false, "A_1.mp4", "/videos/3_B.mp4", 1 },
                    { 7, "Image", false, "A_1.mp4", "/videos/4_A.mp4", 1 },
                    { 8, "Image", false, "A_1.mp4", "/videos/4_B.mp4", 1 },
                    { 9, "Image", false, "A_1.mp4", "/videos/5_A.mp4", 1 },
                    { 10, "Image", false, "A_1.mp4", "/videos/5_B.mp4", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "/videos/A_1.mp4");
        }
    }
}
