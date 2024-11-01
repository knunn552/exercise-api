namespace exercise_api.Repository
{
    public interface IExerciseRepository
    {
        public Task<List<Exercise>> GetExercisesByWorkoutTypeAsync(string workouttype);
    }
}
