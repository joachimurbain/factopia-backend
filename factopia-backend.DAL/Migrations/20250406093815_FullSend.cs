using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FullSend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserQuestions",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuestions", x => new { x.UserId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_UserQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuestions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "REgarde la video ensuite, swipe a droite si c'est vrai !", "TikTok" },
                    { 2, "Fun fact, annecdote et autre conseil.", "Le Saviez-vous ?" },
                    { 3, "", "Vrai ou Fake?" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "GameTypeId" },
                values: new object[,]
                {
                    { 1, "Regarde et decide si c'est vrai", 1 },
                    { 2, "Les chats ont cinq orteils à chaque patte avant.", 3 },
                    { 3, "Le sucre rend les enfants hyperactifs.", 3 },
                    { 4, "Le lait aide à réparer les os cassés.", 3 },
                    { 5, "Les éléphants sont les seuls animaux qui ne peuvent pas sauter.", 3 },
                    { 6, "L'homme a plus de dents que la femme.", 3 },
                    { 7, "Le miel ne se périme jamais.", 3 },
                    { 8, "Les oranges contiennent de la vitamine C.", 3 },
                    { 9, "Le cœur humain est capable de continuer à battre après la mort.", 3 },
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
                    { 16, "Faux", false, 9 },
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
                    { 1, "Video", false, "A_1.mp4", "/videos/1_Fake.mp4", 10 },
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

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_GameTypeId",
                table: "Questions",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_QuestionId",
                table: "Resources",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestions_QuestionId",
                table: "UserQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "UserQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GameTypes");
        }
    }
}
