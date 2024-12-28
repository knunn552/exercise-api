namespace exercise_api.Service
{
    public interface IExerciseService
    {
        public Task<List<Exercise>> GetExercisesByWorkoutTypeAsync(string workouttype);
    }
}
