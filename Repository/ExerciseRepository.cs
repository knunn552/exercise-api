
using exercise_api.ExerciseContext;
using Microsoft.EntityFrameworkCore;

namespace exercise_api.Repository
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ExerciseDbContext _context;

        public ExerciseRepository(ExerciseDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Exercise>> GetExercisesByWorkoutTypeAsync(string workouttype)
        {
            // Were returning a Task of List of Exercises but that will be a List of ExerciseDto
            List<Exercise> exerciseList = await _context.Exercises.Where(e => e.WorkoutType == workouttype).ToListAsync();
            return exerciseList;
        }
    }
}
