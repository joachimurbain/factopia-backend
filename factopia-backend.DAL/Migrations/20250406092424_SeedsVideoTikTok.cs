using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedsVideoTikTok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "GameTypeId" },
                values: new object[,]
                {
                    { 10, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 11, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 12, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 13, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 14, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 15, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 16, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 17, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 18, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 19, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 20, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 21, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 22, "Cette vidéo est-elle fake ou réelle ?", 1 },
                    { 23, "Cette vidéo est-elle fake ou réelle ?", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FileType", "Path", "QuestionId" },
                values: new object[] { "Video", "/videos/1_Fake.mp4", 10 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 17, "Bien vu, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", true, 10 },
                    { 18, "Désolé, vous vous êtes trompé, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", false, 10 },
                    { 19, "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", true, 11 },
                    { 20, "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", false, 11 },
                    { 21, "Bien vu, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. Un détail permettait de déceler le fake : le bras d'une personne assise à droite de l'image a esquissé un mouvement pas très naturel. Certaines pailles dans les verres sur le plateau bougent bizarrement aussi. ", true, 12 },
                    { 22, "Désolé, vous vous êtes trompé, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. Certains détails auraient pu vous mettre sur la piste  : le bras d'une personne assise à droite de l'image a esquissé un mouvement pas très naturel. Certaines pailles dans les verres sur le plateau bougent bizarrement aussi. ", false, 12 },
                    { 23, "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", true, 13 },
                    { 24, "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", false, 13 },
                    { 25, "Bravo, décidément, on ne vous la fait pas à vous!. Il faut dire que c'était facile avec le téléphone gigantesque en arrière-plan et les mains qui semblent à peine toucher le clavier. Nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette vidéo,", true, 14 },
                    { 26, "Désolé, vous vous êtes trompé, vous auriez pu trouver, si vous aviez remarqué le téléphone gigantesque en arrière-plan et les mains qui semblent à peine toucher le clavier, vous auriez pu trouver. Nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer la première vidéo.", false, 14 },
                    { 27, "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", true, 15 },
                    { 28, "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", false, 15 },
                    { 29, "Bien vu ! Vous avez peut-être été frappé par l'aspect trop lisse des bâtiments et par le drapeau américain au premier plan qui bouge avec un mouvement pas très naturel. Encore une fois, c'est l'oeuvre de Sora, tandis que l'autre vidéo vient de Getty Images.", true, 16 },
                    { 30, "Désolé, vous vous êtes trompé, vous auriez pu deviner, si vous aviez remarqué  l'aspect trop lisse des bâtiments et par le drapeau américain au premier plan qui bouge avec un mouvement pas très naturel. Encore une fois, c'est l'oeuvre de Sora,", false, 16 },
                    { 31, "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", true, 17 },
                    { 32, "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", false, 17 },
                    { 33, "Bien vu !  Ce jeune homme est le résultat de l'imagination de l'IA", true, 18 },
                    { 34, "Désolé, vous vous êtes trompé ! Ce jeune homme est le résultat de l'imagination de l'IA", false, 18 },
                    { 35, "Bien vu, il s'agit bien d'une vidéo probablement tournée sur un trampoline, qui vient de Getty Images.", true, 19 },
                    { 36, "Désolé, il s'agit en faite d'une vidéo de Getty Images probablement tournée sur un trampoline.", false, 19 },
                    { 37, "Vrai", true, 20 },
                    { 38, "Faux", false, 20 },
                    { 39, "Vrai", true, 21 },
                    { 40, "Faux", false, 21 },
                    { 41, "Vrai", true, 22 },
                    { 42, "Faux", false, 22 },
                    { 43, "Vrai", true, 23 },
                    { 44, "Faux", false, 23 }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "FileType", "IsCorrect", "Name", "Path", "QuestionId" },
                values: new object[,]
                {
                    { 2, "Video", false, "A_1.mp4", "/videos/1_Real.mp4", 11 },
                    { 3, "Video", false, "A_1.mp4", "/videos/2_Fake.mp4", 12 },
                    { 4, "Video", false, "A_1.mp4", "/videos/2_Real.mp4", 13 },
                    { 5, "Video", false, "A_1.mp4", "/videos/3_Fake.mp4", 14 },
                    { 6, "Video", false, "A_1.mp4", "/videos/3_Real.mp4", 15 },
                    { 7, "Video", false, "A_1.mp4", "/videos/4_Fake.mp4", 16 },
                    { 8, "Video", false, "A_1.mp4", "/videos/4_Real.mp4", 17 },
                    { 9, "Video", false, "A_1.mp4", "/videos/5_Fake.mp4", 18 },
                    { 10, "Video", false, "A_1.mp4", "/videos/5_Real.mp4", 19 },
                    { 11, "Video", false, "A_1.mp4", "/videos/Luma AI dropped a Sora competitor – Dream Machine - text-to-video generator that's open to ALL! #ai.mp4", 20 },
                    { 12, "Video", false, "A_1.mp4", "/videos/This is not Morgan Freeman  -  A Deepfake Singularity.mp4", 21 },
                    { 13, "Video", false, "A_1.mp4", "/videos/Trump Gets a Kim Jong Un Haircut – Putin Can’t Stop Laughing! 🤣💈.mp4", 22 },
                    { 14, "Video", false, "A_1.mp4", "/videos/Viral AI Video Trump & Harris Romance Ahead of U.S. Election.mp4", 23 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

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

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FileType", "Path", "QuestionId" },
                values: new object[] { "Image", "/videos/A_1.mp4", 1 });
        }
    }
}
