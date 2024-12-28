using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreWorkouts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=8mryJ3w2S78");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=EAJJQjF2j6s#:~:text=Behind%20the%20Neck%20Pull%2DUp,Maintain%20a%20hollow%20body%20position.");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=N5x5M1x1Gd0");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Behind Neck Overhead Press", "https://www.youtube.com/watch?v=7c2ITqTmv_Y&t=1s" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Landmine Clean Press", "https://www.youtube.com/watch?v=bZRXZZXOEdQ" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Landmine Rotational Press", "https://www.youtube.com/watch?v=ONDeomDVlbE" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=e5DP6961WEk");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=RD_vUnqwqqI");

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
                value: "https://www.youtube.com/watch?v=gwWv7aPcD88");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Kettlebell Hip Flexion", "https://www.youtube.com/watch?v=v7ACdKPXMf8" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=s6L9ZvN-04I");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Side Kick", "https://www.youtube.com/watch?v=isfOg50BElc" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=YdN2Nz9vuRY");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Banded Pull Apart", "https://www.youtube.com/watch?v=MnDpmNYUjbc" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=sVMWoS0OhsI");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=JeMxj4ORbtM");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=SCVCLChPQFY");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=cGnhixvC8uA");

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
                value: "https://www.youtube.com/watch?v=6gvmcqr226U");

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
                value: "https://www.youtube.com/watch?v=cFG8gJlC-D0");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=OuG1smZTsQQ");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=5oMnUzy_hQ8&t=12s");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Back Squat", "https://www.youtube.com/watch?v=Rvy12jFLBFo" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=AweC3UaM14o");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=vgn7bSXkgkA");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=GZAKFRNtxLY&t=6s");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=9ZknEYboBOQ");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=m0AIU1dCVkU");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Description", "ExerciseType", "Name", "VideoUrl", "WorkoutType" },
                values: new object[,]
                {
                    { 38, null, "Primary", "Front Loaded Forward Lunges", "https://www.youtube.com/watch?v=JGQidbn14GI", "LowerBodyStrength" },
                    { 39, null, "Secondary", "Dumbbell Lunges", "https://www.youtube.com/watch?v=h4N6Ic-3LJI", "LowerBodyStrength" },
                    { 40, null, "Primary", "Overhead Front Lunges", "https://www.youtube.com/watch?v=m6MczOv_Ayg", "LowerBodyStrength" },
                    { 41, null, "Accessory", "Banded Front Monster Walks", "https://www.youtube.com/watch?v=mWlgcUfCsTo", "LowerBodyStrength" },
                    { 42, null, "Accessory", "Banded Lateral Walks", "https://www.youtube.com/watch?v=owcmPqkhAO4", "LowerBodyStrength" },
                    { 43, null, "Accessory", "Banded Adductor Pulls", "https://www.youtube.com/watch?v=YXSxxzKHYdg", "LowerBodyStrength" },
                    { 44, null, "Primary", "Leg Press", "https://www.youtube.com/watch?v=NHcaiGLhEK8", "LowerBodyStrength" },
                    { 45, null, "Secondary", "Goblet Squat", "https://www.youtube.com/watch?v=JxhPHvR88rw", "LowerBodyStrength" },
                    { 46, null, "Secondary", "Close Grip Bench Press", "https://www.youtube.com/watch?v=DzA2xZhDGeo", "UpperBodyStrength" },
                    { 47, null, "Secondary", "Reverse Grip Bench Press", "https://www.youtube.com/watch?v=_y5VJGlk32I", "UpperBodyStrength" },
                    { 48, null, "Primary", "Barbell Rows", "https://www.youtube.com/watch?v=bm0_q9bR_HA", "UpperBodyStrength" },
                    { 49, null, "Secondary", "Reverse Barbell Rows", "https://www.youtube.com/watch?v=cZvQNvTUUu0", "UpperBodyStrength" },
                    { 50, null, "Primary", "Front Squat", "https://www.youtube.com/watch?v=CE0uSrr4SYQ", "LowerBodyStrength" },
                    { 51, null, "Secondary", "Reverse Grip RDL", "https://www.youtube.com/watch?v=ZPHLuDKJFls", "LowerBodyStrength" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 51);

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
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Behind+The+Neck+Pull+Up");

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
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Behind Head Overhead Barbell Press", "https://www.youtube.com/results?search_query=Behind+the+Neck+Overhead+Press+demo" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Landmine Twist Push", "https://www.youtube.com/results?search_query=Landmine+twist+press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Landmine Pull Rotation", "https://www.youtube.com/results?search_query=Power%3A+Landmine+Pull+to+Press" });

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
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Sidekicks", "https://www.youtube.com/results?search_query=Alternating+Side+Kicks" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Banded Palm Up Banded Pulls", "https://www.youtube.com/results?search_query=Band+Pull+Apart" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Band+Chest+Fly");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Prone+Swimmers");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=bench+press");

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
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=Reverse+Tricep+Pushups");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                columns: new[] { "Name", "VideoUrl" },
                values: new object[] { "Squat", "https://www.youtube.com/results?search_query=The+Back+Squat" });

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
                column: "VideoUrl",
                value: "https://www.youtube.com/results?search_query=glute+ham+raises+demo");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Description", "ExerciseType", "Name", "VideoUrl", "WorkoutType" },
                values: new object[,]
                {
                    { 15, null, "Accessory", "Reverse Grip Banded Overhead Rotations", "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation", "UpperBodyStrength" },
                    { 16, null, "Accessory", "Front Palm Down Banded Pulls", "https://www.youtube.com/results?search_query=Band+Pull+Apart", "UpperBodyStrength" }
                });
        }
    }
}
