using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataWithVideoUrls : Migration
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
                    { 1, null, "Core", "Chin Ups", "https://www.youtube.com/watch?v=mTRT9O5r8Wg", "UpperBodyStrength" },
                    { 2, null, "Core", "Backups", "https://www.youtube.com/watch?v=EAJJQjF2j6s", "UpperBodyStrength" },
                    { 3, null, "Core", "Barbell Curls", "https://www.youtube.com/watch?v=qUX2ckeMa08", "UpperBodyStrength" },
                    { 4, null, "Core", "Behind Head Overhead Barbell Press", "https://www.youtube.com/watch?v=7c2ITqTmv_Y", "UpperBodyStrength" },
                    { 5, null, "Core", "Landmine Twist Push", "https://www.youtube.com/watch?v=sQ6xBgPRdPU", "UpperBodyStrength" },
                    { 6, null, "Core", "Landmine Pull Rotation", "https://www.youtube.com/watch?v=80GP0VlFXsM", "UpperBodyStrength" },
                    { 7, null, "Core", "Landmine Rotations", "https://www.youtube.com/watch?v=MswsBPLGhE8", "UpperBodyStrength" },
                    { 8, null, "Core", "Overhead Squats", "https://www.youtube.com/watch?v=6wzpijkqZzg", "LowerBodyStrength" },
                    { 9, null, "Core", "Front Lunges", "https://www.youtube.com/watch?v=g8-Ge9S0aUw", "LowerBodyStrength" },
                    { 10, null, "Core", "Side Lunges", "https://www.youtube.com/watch?v=1D_tsUSW3ZY", "LowerBodyStrength" },
                    { 11, null, "Accessory", "Hip Ups", "https://www.youtube.com/watch?v=Ku2P2ON7rYw", "LowerBodyStrength" },
                    { 12, null, "Secondary", "Calf Raises", "https://www.youtube.com/watch?v=c5Kv6-fnTj8", "LowerBodyStrength" },
                    { 13, null, "Accessory", "Sidekicks", "https://www.youtube.com/watch?v=IV1V8G_5fVU", "LowerBodyStrength" },
                    { 14, null, "Accessory", "Banded Overhead Rotations", "https://www.youtube.com/watch?v=8ye8EARmRQQ", "UpperBodyStrength" },
                    { 15, null, "Accessory", "Reverse Grip Banded Overhead Rotations", "https://www.youtube.com/watch?v=8ye8EARmRQQ", "UpperBodyStrength" },
                    { 16, null, "Accessory", "Front Palm Down Banded Pulls", "https://www.youtube.com/watch?v=MnDpmNYUjbc", "UpperBodyStrength" },
                    { 17, null, "Accessory", "Banded Palm Up Banded Pulls", "https://www.youtube.com/watch?v=MnDpmNYUjbc", "UpperBodyStrength" },
                    { 18, null, "Accessory", "Back Banded Palm Down Pulls", "https://www.youtube.com/watch?v=yVcEkvgymt8", "UpperBodyStrength" },
                    { 19, null, "Accessory", "Back Banded Palm Up Pulls", "https://www.youtube.com/watch?v=yVcEkvgymt8", "UpperBodyStrength" },
                    { 20, null, "Accessory", "Swimmers", "https://www.youtube.com/watch?v=M8a1cgnhyqk", "UpperBodyStrength" },
                    { 21, null, "Core", "Bench Press", "https://www.youtube.com/watch?v=wzq57DB5Ppg", "UpperBodyStrength" },
                    { 22, null, "Core", "Overhead Press", "https://www.youtube.com/watch?v=-5MmFTKLC-0", "UpperBodyStrength" },
                    { 23, null, "Core", "Pull-Ups", "https://www.youtube.com/watch?v=aAggnpPyR6E", "UpperBodyStrength" },
                    { 24, null, "Secondary", "Dumbbell Rows", "https://www.youtube.com/watch?v=3mmaTrhUWNM", "UpperBodyStrength" },
                    { 25, null, "Secondary", "Incline Bench Press", "https://www.youtube.com/watch?v=2jFFCy8JBU8", "UpperBodyStrength" },
                    { 26, null, "Secondary", "Dips", "https://www.youtube.com/watch?v=CRP7tS7RIJU", "UpperBodyStrength" },
                    { 27, null, "Accessory", "Lateral Raises", "https://www.youtube.com/watch?v=c3FkUjXxWmM", "UpperBodyStrength" },
                    { 28, null, "Accessory", "Tricep Pushdowns", "https://www.youtube.com/watch?v=5oMnUzy_hQ8", "UpperBodyStrength" },
                    { 30, null, "Core", "Squat", "https://www.youtube.com/watch?v=ultWZbUMPL8", "LowerBodyStrength" },
                    { 31, null, "Core", "Deadlift", "https://www.youtube.com/watch?v=op9kVnSso6Q", "LowerBodyStrength" },
                    { 33, null, "Secondary", "Bulgarian Split Squat", "https://www.youtube.com/watch?v=9p5e2BSvoLs", "LowerBodyStrength" },
                    { 34, null, "Secondary", "Romanian Deadlift", "https://www.youtube.com/watch?v=GZAKFRNtxLY", "LowerBodyStrength" },
                    { 35, null, "Secondary", "Step-Ups", "https://www.youtube.com/watch?v=i1uM-CbfTBo", "LowerBodyStrength" },
                    { 37, null, "Accessory", "Glute Bridges", "https://www.youtube.com/watch?v=m0AIU1dCVkU", "LowerBodyStrength" }
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
