using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class First_question_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Content", "GameTypeId" },
                values: new object[] { 1, "Regarde et decide si c'est vrai", 1 });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FileType", "IsCorrect", "Name", "Path", "QuestionId" },
                values: new object[] { 1, "Image", false, "A_1.mp4", "/videos/A_1.mp4", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
