using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FullRenaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Question_QuestionId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_GameType_GameTypeId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestion_Question_QuestionId",
                table: "UserQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestion_User_UserId",
                table: "UserQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserQuestion",
                table: "UserQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameType",
                table: "GameType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "UserQuestion",
                newName: "UserQuestions");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "GameType",
                newName: "GameTypes");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_UserQuestion_QuestionId",
                table: "UserQuestions",
                newName: "IX_UserQuestions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_GameTypeId",
                table: "Questions",
                newName: "IX_Questions_GameTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_QuestionId",
                table: "Resources",
                newName: "IX_Resources_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_QuestionId",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserQuestions",
                table: "UserQuestions",
                columns: new[] { "UserId", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTypes",
                table: "GameTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resources",
                table: "Resources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_GameTypes_GameTypeId",
                table: "Questions",
                column: "GameTypeId",
                principalTable: "GameTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Questions_QuestionId",
                table: "Resources",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestions_Questions_QuestionId",
                table: "UserQuestions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestions_Users_UserId",
                table: "UserQuestions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_GameTypes_GameTypeId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Questions_QuestionId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestions_Questions_QuestionId",
                table: "UserQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestions_Users_UserId",
                table: "UserQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserQuestions",
                table: "UserQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resources",
                table: "Resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTypes",
                table: "GameTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserQuestions",
                newName: "UserQuestion");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Files");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "GameTypes",
                newName: "GameType");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_UserQuestions_QuestionId",
                table: "UserQuestion",
                newName: "IX_UserQuestion_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_QuestionId",
                table: "Files",
                newName: "IX_Files_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_GameTypeId",
                table: "Question",
                newName: "IX_Question_GameTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "Answer",
                newName: "IX_Answer_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserQuestion",
                table: "UserQuestion",
                columns: new[] { "UserId", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameType",
                table: "GameType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Question_QuestionId",
                table: "Files",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_GameType_GameTypeId",
                table: "Question",
                column: "GameTypeId",
                principalTable: "GameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestion_Question_QuestionId",
                table: "UserQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestion_User_UserId",
                table: "UserQuestion",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
