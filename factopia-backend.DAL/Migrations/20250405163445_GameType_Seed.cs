using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class GameType_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameType",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "REgarde la video ensuite, swipe a droite si c'est vrai !", "TikTok" },
                    { 2, "Fun fact, annecdote et autre conseil.", "Le Saviez-vous ?" },
                    { 3, "", "Vrai ou Fake?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
