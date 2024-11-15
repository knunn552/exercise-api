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
                new Exercise { ExerciseId = 1, Name = "Chin Ups", Description = "A pulling exercise targeting the biceps and back muscles, pulling the body up to a bar with palms facing towards you.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 2, Name = "Backups", Description = "A pulling exercise targeting the upper back and biceps, often performed on a bar or with a suspension trainer.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 3, Name = "Barbell Curls", Description = "An isolation exercise focusing on the biceps, performed by curling a barbell towards the shoulders.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 4, Name = "Behind Head Overhead Barbell Press", Description = "A shoulder press variation that targets the shoulders and upper back, pressing a barbell behind the head.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 5, Name = "Landmine Twist Push", Description = "A twisting movement using a landmine attachment to engage the core while pushing the weight forward.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 6, Name = "Landmine Pull Rotation", Description = "A rotational movement with a landmine that targets the core and back muscles while pulling the weight.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 7, Name = "Landmine Rotations", Description = "A core exercise using a landmine to rotate the body, engaging the obliques and stabilizing muscles.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 8, Name = "Overhead Squats", Description = "A squat variation performed with a barbell held overhead, targeting the entire body and requiring core stability.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 9, Name = "Front Lunges", Description = "A dynamic movement targeting the quadriceps, glutes, and hamstrings by stepping forward into a lunge position.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 10, Name = "Side Lunges", Description = "A lateral movement that engages the inner and outer thighs by stepping to the side into a lunge position.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 11, Name = "Hip Ups", Description = "An exercise that targets the glutes and lower back, performed by lifting the hips off the ground while lying down.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 12, Name = "Calf Raises", Description = "An isolation exercise focusing on the calves, performed by raising the heels off the ground while standing.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 13, Name = "Sidekicks", Description = "A lateral leg lift targeting the hip abductors and glutes, performed by kicking the leg to the side.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 14, Name = "Banded Overhead Rotations", Description = "An exercise that engages the shoulders and core while rotating a resistance band overhead.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 15, Name = "Reverse Grip Banded Overhead Rotations", Description = "A variation of overhead rotations performed with a reverse grip to target different shoulder muscles.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 16, Name = "Front Palm Down Banded Pulls", Description = "An exercise targeting the upper back and shoulders by pulling a resistance band towards the chest with palms down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 17, Name = "Banded Palm Up Banded Pulls", Description = "A pulling exercise targeting the upper back and biceps, performed with palms facing up on a resistance band.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 18, Name = "Back Banded Palm Down Pulls", Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 19, Name = "Back Banded Palm Up Pulls", Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing up.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 20, Name = "Swimmers", Description = "A core and shoulder stability exercise performed by extending arms and legs while lying face down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 21, Name = "Bench Press", Description = "A compound upper body exercise.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 22, Name = "Overhead Press", Description = "A shoulder press exercise.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 23, Name = "Pull-Ups", Description = "Bodyweight exercise for upper body.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 24, Name = "Dumbbell Rows", Description = "Upper back exercise.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 25, Name = "Incline Bench Press", Description = "Variation of bench press.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 26, Name = "Dips", Description = "Triceps-focused bodyweight exercise.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 27, Name = "Lateral Raises", Description = "Shoulder isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 28, Name = "Tricep Pushdowns", Description = "Triceps isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 29, Name = "Bicep Curls", Description = "Biceps isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { ExerciseId = 30, Name = "Squat", Description = "A compound lower body exercise.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 31, Name = "Deadlift", Description = "A compound lift for posterior chain.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 32, Name = "Leg Press", Description = "Lower body machine-based exercise.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 33, Name = "Bulgarian Split Squat", Description = "Single-leg exercise.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 34, Name = "Romanian Deadlift", Description = "Hamstring-targeted exercise.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 35, Name = "Step-Ups", Description = "Lower body exercise with step.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 36, Name = "Hamstring Curls", Description = "Machine-based hamstring exercise.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { ExerciseId = 37, Name = "Glute Bridges", Description = "Glute-focused exercise.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" }
            );
        }
    }
}
