namespace exercise_api.DTO
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ExerciseType { get; set; }
        public string WorkoutType { get; set; }
    }
}
