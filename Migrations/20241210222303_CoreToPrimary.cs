using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class CoreToPrimary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                column: "ExerciseType",
                value: "Primary");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "ExerciseType",
                value: "Primary");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                column: "ExerciseType",
                value: "Core");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "ExerciseType",
                value: "Core");
        }
    }
}
