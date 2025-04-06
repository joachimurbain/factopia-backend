using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AnotherFixSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/videos/LumaAIdroppedaSoracompetitor–Dream Machine-text-to-videogeneratorthatsopentoALLai.mp4.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "/videos/ThisisnotMorganFreemanADeepfakeSingularity.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "Path",
                value: "/videos/TrumpGetsaKimJongUnHaircut–PutinCantStopLaughing.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "Path",
                value: "/videos/ViralAIVideoTrumpHarrisRomanceAheadofUSElection.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/videos/Luma AI dropped a Sora competitor – Dream Machine - text-to-video generator that's open to ALL! #ai.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "/videos/This is not Morgan Freeman  -  A Deepfake Singularity.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "Path",
                value: "/videos/Trump Gets a Kim Jong Un Haircut – Putin Can’t Stop Laughing! 🤣💈.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "Path",
                value: "/videos/Viral AI Video Trump & Harris Romance Ahead of U.S. Election.mp4");
        }
    }
}
