using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationTestingLocalSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Description", "ExerciseType", "Name", "VideoUrl", "WorkoutType" },
                values: new object[,]
                {
                    { 1, null, "Core", "Chin Ups", "https://www.youtube.com/results?search_query=chin+ups+demo", "UpperBodyStrength" },
                    { 2, null, "Core", "Behind Neck Pull Ups", "https://www.youtube.com/results?search_query=Behind+The+Neck+Pull+Up", "UpperBodyStrength" },
                    { 3, null, "Core", "Barbell Curls", "https://www.youtube.com/results?search_query=Barbell+Biceps+Curl+-+Demo", "UpperBodyStrength" },
                    { 4, null, "Core", "Behind Head Overhead Barbell Press", "https://www.youtube.com/results?search_query=Behind+the+Neck+Overhead+Press+demo", "UpperBodyStrength" },
                    { 5, null, "Core", "Landmine Twist Push", "https://www.youtube.com/results?search_query=Landmine+twist+press", "UpperBodyStrength" },
                    { 6, null, "Core", "Landmine Pull Rotation", "https://www.youtube.com/results?search_query=Power%3A+Landmine+Pull+to+Press", "UpperBodyStrength" },
                    { 7, null, "Core", "Landmine Rotations", "https://www.youtube.com/results?search_query=Landmine+Rotation", "UpperBodyStrength" },
                    { 8, null, "Core", "Overhead Squats", "https://www.youtube.com/results?search_query=OVERHEAD+SQUAT", "LowerBodyStrength" },
                    { 9, null, "Core", "Front Lunges", "https://www.youtube.com/results?search_query=How+To+Do+A+Forward+Lunge", "LowerBodyStrength" },
                    { 10, null, "Core", "Side Lunges", "https://www.youtube.com/results?search_query=Side+Lunges+Demonstration", "LowerBodyStrength" },
                    { 11, null, "Accessory", "Hip Flexor Raises", "https://www.youtube.com/results?search_query=Kettlebell+Hip+Flexor+Raise", "LowerBodyStrength" },
                    { 12, null, "Secondary", "Calf Raises", "https://www.youtube.com/results?search_query=Calf+Raise+Exercise+Demo", "LowerBodyStrength" },
                    { 13, null, "Accessory", "Sidekicks", "https://www.youtube.com/results?search_query=Alternating+Side+Kicks", "LowerBodyStrength" },
                    { 14, null, "Accessory", "Banded Overhead Rotations", "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation", "UpperBodyStrength" },
                    { 15, null, "Accessory", "Reverse Grip Banded Overhead Rotations", "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation", "UpperBodyStrength" },
                    { 16, null, "Accessory", "Front Palm Down Banded Pulls", "https://www.youtube.com/results?search_query=Band+Pull+Apart", "UpperBodyStrength" },
                    { 17, null, "Accessory", "Banded Palm Up Banded Pulls", "https://www.youtube.com/results?search_query=Band+Pull+Apart", "UpperBodyStrength" },
                    { 18, null, "Accessory", "Banded Chest Flys", "https://www.youtube.com/results?search_query=Band+Chest+Fly", "UpperBodyStrength" },
                    { 20, null, "Accessory", "Prone Swimmers", "https://www.youtube.com/results?search_query=Prone+Swimmers", "UpperBodyStrength" },
                    { 21, null, "Core", "Bench Press", "https://www.youtube.com/results?search_query=bench+press", "UpperBodyStrength" },
                    { 22, null, "Core", "Overhead Press", "https://www.youtube.com/results?search_query=How+To+Perfect+The+Overhead+Press", "UpperBodyStrength" },
                    { 23, null, "Core", "Pull-Ups", "https://www.youtube.com/results?search_query=pull+up+demo", "UpperBodyStrength" },
                    { 24, null, "Secondary", "Dumbbell Rows", "https://www.youtube.com/results?search_query=Dumbbell+Row+(Exercise+Demo)", "UpperBodyStrength" },
                    { 25, null, "Secondary", "Incline Bench Press", "https://www.youtube.com/results?search_query=How+To+Do+A+Barbell+Incline+Bench+Press", "UpperBodyStrength" },
                    { 26, null, "Secondary", "Dips", "https://www.youtube.com/results?search_query=How+To+Do+Bench+Dips+%7C+Exercise+Demo", "UpperBodyStrength" },
                    { 27, null, "Accessory", "Lateral Raises", "https://www.youtube.com/results?search_query=How+to+do+a+lateral+raise+-+20+second+demo", "UpperBodyStrength" },
                    { 28, null, "Accessory", "Reverse Tricep Pushups", "https://www.youtube.com/results?search_query=Reverse+Tricep+Pushups", "UpperBodyStrength" },
                    { 30, null, "Core", "Squat", "https://www.youtube.com/results?search_query=The+Back+Squat", "LowerBodyStrength" },
                    { 31, null, "Core", "Deadlift", "https://www.youtube.com/results?search_query=The+Deadlift%3A+CrossFit+Foundational+Movement", "LowerBodyStrength" },
                    { 33, null, "Secondary", "Bulgarian Split Squat", "https://www.youtube.com/results?search_query=Bulgarian+Split+Squat+Step+by+Step+Guide", "LowerBodyStrength" },
                    { 34, null, "Secondary", "Romanian Deadlift", "https://www.youtube.com/results?search_query=Movement+Demo+-+The+Romanian+Deadlift", "LowerBodyStrength" },
                    { 35, null, "Secondary", "Step-Ups", "https://www.youtube.com/results?search_query=Box+Step+Up+Demo", "LowerBodyStrength" },
                    { 37, null, "Secondary", "Glute Ham Raises", "https://www.youtube.com/results?search_query=glute+ham+raises+demo", "LowerBodyStrength" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
