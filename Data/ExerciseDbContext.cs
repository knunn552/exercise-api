using Microsoft.EntityFrameworkCore;

namespace exercise_api.ExerciseContext
{
    public class ExerciseDbContext : DbContext
    {
        public ExerciseDbContext(DbContextOptions<ExerciseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { ExerciseId = 1, Name = "Chin Ups", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=mTRT9O5r8Wg" },
                new Exercise { ExerciseId = 2, Name = "Backups", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=EAJJQjF2j6s" },
                new Exercise { ExerciseId = 3, Name = "Barbell Curls", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=qUX2ckeMa08" },
                new Exercise { ExerciseId = 4, Name = "Behind Head Overhead Barbell Press", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=7c2ITqTmv_Y" },
                new Exercise { ExerciseId = 5, Name = "Landmine Twist Push", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=sQ6xBgPRdPU" },
                new Exercise { ExerciseId = 6, Name = "Landmine Pull Rotation", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=80GP0VlFXsM" },
                new Exercise { ExerciseId = 7, Name = "Landmine Rotations", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=MswsBPLGhE8" },
                new Exercise { ExerciseId = 8, Name = "Overhead Squats", ExerciseType = "Core", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=6wzpijkqZzg" },
                new Exercise { ExerciseId = 9, Name = "Front Lunges", ExerciseType = "Core", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=g8-Ge9S0aUw" },
                new Exercise { ExerciseId = 10, Name = "Side Lunges", ExerciseType = "Core", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=1D_tsUSW3ZY" },
                new Exercise { ExerciseId = 11, Name = "Hip Ups", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=Ku2P2ON7rYw" },
                new Exercise { ExerciseId = 12, Name = "Calf Raises", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=c5Kv6-fnTj8" },
                new Exercise { ExerciseId = 13, Name = "Sidekicks", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=IV1V8G_5fVU" },
                new Exercise { ExerciseId = 14, Name = "Banded Overhead Rotations", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=8ye8EARmRQQ" },
                new Exercise { ExerciseId = 15, Name = "Reverse Grip Banded Overhead Rotations", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=8ye8EARmRQQ" },
                new Exercise { ExerciseId = 16, Name = "Front Palm Down Banded Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=MnDpmNYUjbc" },
                new Exercise { ExerciseId = 17, Name = "Banded Palm Up Banded Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=MnDpmNYUjbc" },
                new Exercise { ExerciseId = 18, Name = "Back Banded Palm Down Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=yVcEkvgymt8" },
                new Exercise { ExerciseId = 19, Name = "Back Banded Palm Up Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=yVcEkvgymt8" },
                new Exercise { ExerciseId = 20, Name = "Swimmers", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=M8a1cgnhyqk" },
                new Exercise { ExerciseId = 21, Name = "Bench Press", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=wzq57DB5Ppg" },
                new Exercise { ExerciseId = 22, Name = "Overhead Press", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=-5MmFTKLC-0" },
                new Exercise { ExerciseId = 23, Name = "Pull-Ups", ExerciseType = "Core", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=aAggnpPyR6E" },
                new Exercise { ExerciseId = 24, Name = "Dumbbell Rows", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=3mmaTrhUWNM" },
                new Exercise { ExerciseId = 25, Name = "Incline Bench Press", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=2jFFCy8JBU8" },
                new Exercise { ExerciseId = 26, Name = "Dips", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=CRP7tS7RIJU" },
                new Exercise { ExerciseId = 27, Name = "Lateral Raises", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=c3FkUjXxWmM" },
                new Exercise { ExerciseId = 28, Name = "Tricep Pushdowns", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=5oMnUzy_hQ8" },
                new Exercise { ExerciseId = 30, Name = "Squat", ExerciseType = "Core", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=ultWZbUMPL8" },
                new Exercise { ExerciseId = 31, Name = "Deadlift", ExerciseType = "Core", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=op9kVnSso6Q" },
                new Exercise { ExerciseId = 33, Name = "Bulgarian Split Squat", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=9p5e2BSvoLs" },
                new Exercise { ExerciseId = 34, Name = "Romanian Deadlift", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=GZAKFRNtxLY" },
                new Exercise { ExerciseId = 35, Name = "Step-Ups", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=i1uM-CbfTBo" },
                new Exercise { ExerciseId = 37, Name = "Glute Bridges", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/watch?v=m0AIU1dCVkU" }
            );
        }
    }
}
