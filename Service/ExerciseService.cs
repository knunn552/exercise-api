using exercise_api.ExerciseContext;
using exercise_api.Repository;

namespace exercise_api.Service
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        public async Task<List<Exercise>> GetExercisesByWorkoutTypeAsync(string workouttype)
        {
            try
            {
                return await _exerciseRepository.GetExercisesByWorkoutTypeAsync(workouttype);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Could not get Exercise data from the database", ex.Message);
            }
            return null;
        }
    }
}
