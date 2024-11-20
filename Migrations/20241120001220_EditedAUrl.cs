using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class EditedAUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=bench+press");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=wzq57DB5Ppg");
        }
    }
}
