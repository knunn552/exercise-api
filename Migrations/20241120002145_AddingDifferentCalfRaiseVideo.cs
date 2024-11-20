using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddingDifferentCalfRaiseVideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=eMTy3qylqnE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=c5Kv6-fnTj8");
        }
    }
}
