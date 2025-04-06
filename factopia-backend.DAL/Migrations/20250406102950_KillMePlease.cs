using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace factopia_backend.DAL.Migrations
{
    /// <inheritdoc />
    public partial class KillMePlease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/videos/LumaAI.mp4.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "/videos/ThisisnotMorganFreeman.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "Path",
                value: "/videos/TrumpGetsaKimJongUnHaircut.mp4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "Path",
                value: "/videos/ViralAIVideoTrump.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
