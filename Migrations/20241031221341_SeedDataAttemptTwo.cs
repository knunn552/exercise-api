using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAttemptTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "ExerciseType", "Name", "WorkoutType" },
                values: new object[,]
                {
                    { 1, "A pulling exercise targeting the biceps and back muscles, pulling the body up to a bar with palms facing towards you.", "Core", "Chin Ups", "UpperBodyStrength" },
                    { 2, "A pulling exercise targeting the upper back and biceps, often performed on a bar or with a suspension trainer.", "Core", "Backups", "UpperBodyStrength" },
                    { 3, "An isolation exercise focusing on the biceps, performed by curling a barbell towards the shoulders.", "Core", "Barbell Curls", "UpperBodyStrength" },
                    { 4, "A shoulder press variation that targets the shoulders and upper back, pressing a barbell behind the head.", "Core", "Behind Head Overhead Barbell Press", "UpperBodyStrength" },
                    { 5, "A twisting movement using a landmine attachment to engage the core while pushing the weight forward.", "Core", "Landmine Twist Push", "UpperBodyStrength" },
                    { 6, "A rotational movement with a landmine that targets the core and back muscles while pulling the weight.", "Core", "Landmine Pull Rotation", "UpperBodyStrength" },
                    { 7, "A core exercise using a landmine to rotate the body, engaging the obliques and stabilizing muscles.", "Core", "Landmine Rotations", "UpperBodyStrength" },
                    { 8, "A squat variation performed with a barbell held overhead, targeting the entire body and requiring core stability.", "Core", "Overhead Squats", "LowerBodyStrength" },
                    { 9, "A dynamic movement targeting the quadriceps, glutes, and hamstrings by stepping forward into a lunge position.", "Core", "Front Lunges", "LowerBodyStrength" },
                    { 10, "A lateral movement that engages the inner and outer thighs by stepping to the side into a lunge position.", "Core", "Side Lunges", "LowerBodyStrength" },
                    { 11, "An exercise that targets the glutes and lower back, performed by lifting the hips off the ground while lying down.", "Accessory", "Hip Ups", "LowerBodyStrength" },
                    { 12, "An isolation exercise focusing on the calves, performed by raising the heels off the ground while standing.", "Secondary", "Calf Raises", "LowerBodyStrength" },
                    { 13, "A lateral leg lift targeting the hip abductors and glutes, performed by kicking the leg to the side.", "Accessory", "Sidekicks", "LowerBodyStrength" },
                    { 14, "An exercise that engages the shoulders and core while rotating a resistance band overhead.", "Accessory", "Banded Overhead Rotations", "UpperBodyStrength" },
                    { 15, "A variation of overhead rotations performed with a reverse grip to target different shoulder muscles.", "Accessory", "Reverse Grip Banded Overhead Rotations", "UpperBodyStrength" },
                    { 16, "An exercise targeting the upper back and shoulders by pulling a resistance band towards the chest with palms down.", "Accessory", "Front Palm Down Banded Pulls", "UpperBodyStrength" },
                    { 17, "A pulling exercise targeting the upper back and biceps, performed with palms facing up on a resistance band.", "Accessory", "Banded Palm Up Banded Pulls", "UpperBodyStrength" },
                    { 18, "A pulling exercise targeting the upper back, performed with a resistance band with palms facing down.", "Accessory", "Back Banded Palm Down Pulls", "UpperBodyStrength" },
                    { 19, "A pulling exercise targeting the upper back, performed with a resistance band with palms facing up.", "Accessory", "Back Banded Palm Up Pulls", "UpperBodyStrength" },
                    { 20, "A core and shoulder stability exercise performed by extending arms and legs while lying face down.", "Accessory", "Swimmers", "UpperBodyStrength" },
                    { 21, "A compound upper body exercise.", "Core", "Bench Press", "UpperBodyStrength" },
                    { 22, "A shoulder press exercise.", "Core", "Overhead Press", "UpperBodyStrength" },
                    { 23, "Bodyweight exercise for upper body.", "Core", "Pull-Ups", "UpperBodyStrength" },
                    { 24, "Upper back exercise.", "Secondary", "Dumbbell Rows", "UpperBodyStrength" },
                    { 25, "Variation of bench press.", "Secondary", "Incline Bench Press", "UpperBodyStrength" },
                    { 26, "Triceps-focused bodyweight exercise.", "Secondary", "Dips", "UpperBodyStrength" },
                    { 27, "Shoulder isolation exercise.", "Accessory", "Lateral Raises", "UpperBodyStrength" },
                    { 28, "Triceps isolation exercise.", "Accessory", "Tricep Pushdowns", "UpperBodyStrength" },
                    { 29, "Biceps isolation exercise.", "Accessory", "Bicep Curls", "UpperBodyStrength" },
                    { 30, "A compound lower body exercise.", "Core", "Squat", "LowerBodyStrength" },
                    { 31, "A compound lift for posterior chain.", "Core", "Deadlift", "LowerBodyStrength" },
                    { 32, "Lower body machine-based exercise.", "Core", "Leg Press", "LowerBodyStrength" },
                    { 33, "Single-leg exercise.", "Secondary", "Bulgarian Split Squat", "LowerBodyStrength" },
                    { 34, "Hamstring-targeted exercise.", "Secondary", "Romanian Deadlift", "LowerBodyStrength" },
                    { 35, "Lower body exercise with step.", "Secondary", "Step-Ups", "LowerBodyStrength" },
                    { 36, "Machine-based hamstring exercise.", "Accessory", "Hamstring Curls", "LowerBodyStrength" },
                    { 37, "Glute-focused exercise.", "Accessory", "Glute Bridges", "LowerBodyStrength" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
