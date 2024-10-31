using Microsoft.EntityFrameworkCore;
using System.Numerics;

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
                new Exercise { Id = 1, Name = "Chin Ups", Description = "A pulling exercise targeting the biceps and back muscles, pulling the body up to a bar with palms facing towards you.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 2, Name = "Backups", Description = "A pulling exercise targeting the upper back and biceps, often performed on a bar or with a suspension trainer.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 3, Name = "Barbell Curls", Description = "An isolation exercise focusing on the biceps, performed by curling a barbell towards the shoulders.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 4, Name = "Behind Head Overhead Barbell Press", Description = "A shoulder press variation that targets the shoulders and upper back, pressing a barbell behind the head.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 5, Name = "Landmine Twist Push", Description = "A twisting movement using a landmine attachment to engage the core while pushing the weight forward.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 6, Name = "Landmine Pull Rotation", Description = "A rotational movement with a landmine that targets the core and back muscles while pulling the weight.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 7, Name = "Landmine Rotations", Description = "A core exercise using a landmine to rotate the body, engaging the obliques and stabilizing muscles.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 8, Name = "Overhead Squats", Description = "A squat variation performed with a barbell held overhead, targeting the entire body and requiring core stability.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 9, Name = "Front Lunges", Description = "A dynamic movement targeting the quadriceps, glutes, and hamstrings by stepping forward into a lunge position.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 10, Name = "Side Lunges", Description = "A lateral movement that engages the inner and outer thighs by stepping to the side into a lunge position.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 11, Name = "Hip Ups", Description = "An exercise that targets the glutes and lower back, performed by lifting the hips off the ground while lying down.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 12, Name = "Calf Raises", Description = "An isolation exercise focusing on the calves, performed by raising the heels off the ground while standing.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 13, Name = "Sidekicks", Description = "A lateral leg lift targeting the hip abductors and glutes, performed by kicking the leg to the side.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 14, Name = "Banded Overhead Rotations", Description = "An exercise that engages the shoulders and core while rotating a resistance band overhead.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 15, Name = "Reverse Grip Banded Overhead Rotations", Description = "A variation of overhead rotations performed with a reverse grip to target different shoulder muscles.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 16, Name = "Front Palm Down Banded Pulls", Description = "An exercise targeting the upper back and shoulders by pulling a resistance band towards the chest with palms down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 17, Name = "Banded Palm Up Banded Pulls", Description = "A pulling exercise targeting the upper back and biceps, performed with palms facing up on a resistance band.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 18, Name = "Back Banded Palm Down Pulls", Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 19, Name = "Back Banded Palm Up Pulls", Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing up.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 20, Name = "Swimmers", Description = "A core and shoulder stability exercise performed by extending arms and legs while lying face down.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 21, Name = "Bench Press", Description = "A compound upper body exercise.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 22, Name = "Overhead Press", Description = "A shoulder press exercise.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 23, Name = "Pull-Ups", Description = "Bodyweight exercise for upper body.", ExerciseType = "Core", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 24, Name = "Dumbbell Rows", Description = "Upper back exercise.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 25, Name = "Incline Bench Press", Description = "Variation of bench press.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 26, Name = "Dips", Description = "Triceps-focused bodyweight exercise.", ExerciseType = "Secondary", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 27, Name = "Lateral Raises", Description = "Shoulder isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 28, Name = "Tricep Pushdowns", Description = "Triceps isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 29, Name = "Bicep Curls", Description = "Biceps isolation exercise.", ExerciseType = "Accessory", WorkoutType = "UpperBodyStrength" },
                new Exercise { Id = 30, Name = "Squat", Description = "A compound lower body exercise.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 31, Name = "Deadlift", Description = "A compound lift for posterior chain.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 32, Name = "Leg Press", Description = "Lower body machine-based exercise.", ExerciseType = "Core", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 33, Name = "Bulgarian Split Squat", Description = "Single-leg exercise.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 34, Name = "Romanian Deadlift", Description = "Hamstring-targeted exercise.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 35, Name = "Step-Ups", Description = "Lower body exercise with step.", ExerciseType = "Secondary", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 36, Name = "Hamstring Curls", Description = "Machine-based hamstring exercise.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" },
                new Exercise { Id = 37, Name = "Glute Bridges", Description = "Glute-focused exercise.", ExerciseType = "Accessory", WorkoutType = "LowerBodyStrength" }
            );
        }
    }
}
