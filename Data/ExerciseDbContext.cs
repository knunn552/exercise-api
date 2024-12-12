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
    new Exercise { ExerciseId = 1, Name = "Chin Ups", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=chin+ups+demo" },
    new Exercise { ExerciseId = 2, Name = "Behind Neck Pull Ups", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Behind+The+Neck+Pull+Up" },
    new Exercise { ExerciseId = 3, Name = "Barbell Curls", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Barbell+Biceps+Curl+-+Demo" },
    new Exercise { ExerciseId = 4, Name = "Behind Head Overhead Barbell Press", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Behind+the+Neck+Overhead+Press+demo" },
    new Exercise { ExerciseId = 5, Name = "Landmine Twist Push", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Landmine+twist+press" },
    new Exercise { ExerciseId = 6, Name = "Landmine Pull Rotation", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Power%3A+Landmine+Pull+to+Press" },
    new Exercise { ExerciseId = 7, Name = "Landmine Rotations", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Landmine+Rotation" },
    new Exercise { ExerciseId = 8, Name = "Overhead Squats", ExerciseType = "Primary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=OVERHEAD+SQUAT" },
    new Exercise { ExerciseId = 9, Name = "Front Lunges", ExerciseType = "Primary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=How+To+Do+A+Forward+Lunge" },
    new Exercise { ExerciseId = 10, Name = "Side Lunges", ExerciseType = "Primary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Side+Lunges+Demonstration" },
    new Exercise { ExerciseId = 11, Name = "Hip Flexor Raises", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Kettlebell+Hip+Flexor+Raise" },
    new Exercise { ExerciseId = 12, Name = "Calf Raises", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Calf+Raise+Exercise+Demo" },
    new Exercise { ExerciseId = 13, Name = "Sidekicks", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Alternating+Side+Kicks" },
    new Exercise { ExerciseId = 14, Name = "Banded Overhead Rotations", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation" },
    new Exercise { ExerciseId = 15, Name = "Reverse Grip Banded Overhead Rotations", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Resistance+Band+Overhead+Rotation" },
    new Exercise { ExerciseId = 16, Name = "Front Palm Down Banded Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Band+Pull+Apart" },
    new Exercise { ExerciseId = 17, Name = "Banded Palm Up Banded Pulls", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Band+Pull+Apart" },
    new Exercise { ExerciseId = 18, Name = "Banded Chest Flys", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Band+Chest+Fly" },
    new Exercise { ExerciseId = 20, Name = "Prone Swimmers", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Prone+Swimmers" },
    new Exercise { ExerciseId = 21, Name = "Bench Press", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=bench+press" },
    new Exercise { ExerciseId = 22, Name = "Overhead Press", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=How+To+Perfect+The+Overhead+Press" },
    new Exercise { ExerciseId = 23, Name = "Pull-Ups", ExerciseType = "Primary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=pull+up+demo" },
    new Exercise { ExerciseId = 24, Name = "Dumbbell Rows", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Dumbbell+Row+(Exercise+Demo)" },
    new Exercise { ExerciseId = 25, Name = "Incline Bench Press", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=How+To+Do+A+Barbell+Incline+Bench+Press" },
    new Exercise { ExerciseId = 26, Name = "Dips", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=How+To+Do+Bench+Dips+%7C+Exercise+Demo" },
    new Exercise { ExerciseId = 27, Name = "Lateral Raises", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=How+to+do+a+lateral+raise+-+20+second+demo" },
    new Exercise { ExerciseId = 28, Name = "Reverse Tricep Pushups", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Reverse+Tricep+Pushups" },
    new Exercise { ExerciseId = 30, Name = "Squat", ExerciseType = "Primary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=The+Back+Squat" },
    new Exercise { ExerciseId = 31, Name = "Deadlift", ExerciseType = "Primary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=The+Deadlift%3A+CrossFit+Foundational+Movement" },
    new Exercise { ExerciseId = 33, Name = "Bulgarian Split Squat", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Bulgarian+Split+Squat+Step+by+Step+Guide" },
    new Exercise { ExerciseId = 34, Name = "Romanian Deadlift", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Movement+Demo+-+The+Romanian+Deadlift" },
    new Exercise { ExerciseId = 35, Name = "Step-Ups", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=Box+Step+Up+Demo" },
    new Exercise { ExerciseId = 37, Name = "Glute Ham Raises", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength", VideoUrl = "https://www.youtube.com/results?search_query=glute+ham+raises+demo" }

);

        }
    }
}
