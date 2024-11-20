using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAllLinksPleaseWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=chin+ups+demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Behind Neck Pull Ups", "https://www.youtube.com/results?search_query=Behind+The+Neck+Pull+Up" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Barbell+Biceps+Curl+-+Demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Behind+the+Neck+Overhead+Press+demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Landmine+twist+press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Power%3A+Landmine+Pull+to+Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Landmine+Rotation");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=OVERHEAD+SQUAT");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=How+To+Do+A+Forward+Lunge");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Side+Lunges+Demonstration");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Hip Flexor Raises", "https://www.youtube.com/results?search_query=Kettlebell+Hip+Flexor+Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Calf+Raise+Exercise+Demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Alternating+Side+Kicks");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Band+Pull+Apart");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Band+Pull+Apart");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Banded Chest Flys", "https://www.youtube.com/results?search_query=Band+Chest+Fly" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Prone Swimmers", "https://www.youtube.com/results?search_query=Prone+Swimmers" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=How+To+Perfect+The+Overhead+Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=pull+up+demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Dumbbell+Row+(Exercise+Demo)");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=How+To+Do+A+Barbell+Incline+Bench+Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=How+To+Do+Bench+Dips+%7C+Exercise+Demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=How+to+do+a+lateral+raise+-+20+second+demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Reverse Tricep Pushups", "https://www.youtube.com/results?search_query=Reverse+Tricep+Pushups" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=The+Back+Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=The+Deadlift%3A+CrossFit+Foundational+Movement");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Bulgarian+Split+Squat+Step+by+Step+Guide");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Movement+Demo+-+The+Romanian+Deadlift");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Box+Step+Up+Demo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                columns: new[] { "ExerciseType", "Name", "VideoUrl" },
                values: new object[] { "Secondary", "Glute Ham Raises", "https://www.youtube.com/results?search_query=glute+ham+raises+demo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=mTRT9O5r8Wg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Backups", "https://www.youtube.com/watch?v=EAJJQjF2j6s" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=qUX2ckeMa08");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=7c2ITqTmv_Y");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=sQ6xBgPRdPU");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=80GP0VlFXsM");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=MswsBPLGhE8");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=6wzpijkqZzg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=g8-Ge9S0aUw");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=1D_tsUSW3ZY");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Hip Ups", "https://www.youtube.com/watch?v=Ku2P2ON7rYw" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=eMTy3qylqnE");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=IV1V8G_5fVU");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=8ye8EARmRQQ");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=8ye8EARmRQQ");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=MnDpmNYUjbc");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=MnDpmNYUjbc");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Back Banded Palm Down Pulls", "https://www.youtube.com/watch?v=yVcEkvgymt8" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Swimmers", "https://www.youtube.com/watch?v=M8a1cgnhyqk" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=-5MmFTKLC-0");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=aAggnpPyR6E");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=3mmaTrhUWNM");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=2jFFCy8JBU8");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=CRP7tS7RIJU");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=c3FkUjXxWmM");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Tricep Pushdowns", "https://www.youtube.com/watch?v=5oMnUzy_hQ8" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=ultWZbUMPL8");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=op9kVnSso6Q");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=9p5e2BSvoLs");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=GZAKFRNtxLY");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=i1uM-CbfTBo");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                columns: new[] { "ExerciseType", "Name", "VideoUrl" },
                values: new object[] { "Accessory", "Glute Bridges", "https://www.youtube.com/" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Description", "ExerciseType", "Name", "VideoUrl", "WorkoutType" },
                values: new object[] { 19, null, "Accessory", "Back Banded Palm Up Pulls", "https://www.youtube.com/watch?v=yVcEkvgymt8", "UpperBodyStrength" });
        }
    }
}
