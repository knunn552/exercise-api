using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class InsertedGenericYouTubeLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                column: "VideoUrl",
                value: "https://www.youtube.com/");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=m0AIU1dCVkU");
        }
    }
}
