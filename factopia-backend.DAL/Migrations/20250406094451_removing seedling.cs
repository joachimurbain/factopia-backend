using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class removingseedling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Vrai", true, 2 },
                    { 45, "Bien vu, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", true, 1 },
                    { 46, "Désolé, vous vous êtes trompé, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", false, 1 }
                });
        }
    }
}
