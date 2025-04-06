using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewQuestionsVraiFake : Migration
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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "GameTypeId" },
                values: new object[,]
                {
                    { 2, "Les chats ont cinq orteils à chaque patte avant.", 3 },
                    { 3, "Le sucre rend les enfants hyperactifs.", 3 },
                    { 4, "Le lait aide à réparer les os cassés.", 3 },
                    { 5, "Les éléphants sont les seuls animaux qui ne peuvent pas sauter.", 3 },
                    { 6, "L'homme a plus de dents que la femme.", 3 },
                    { 7, "Le miel ne se périme jamais.", 3 },
                    { 8, "Les oranges contiennent de la vitamine C.", 3 },
                    { 9, "Le cœur humain est capable de continuer à battre après la mort.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Vrai", true, 2 },
                    { 2, "Faux", false, 2 },
                    { 3, "Vrai", false, 3 },
                    { 4, "Faux", true, 3 },
                    { 5, "Vrai", true, 4 },
                    { 6, "Faux", false, 4 },
                    { 7, "Vrai", true, 5 },
                    { 8, "Faux", false, 5 },
                    { 9, "Vrai", false, 6 },
                    { 10, "Faux", true, 6 },
                    { 11, "Vrai", true, 7 },
                    { 12, "Faux", false, 7 },
                    { 13, "Vrai", true, 8 },
                    { 14, "Faux", false, 8 },
                    { 15, "Vrai", true, 9 },
                    { 16, "Faux", false, 9 }
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
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
