using AutoMapper;
using exercise_api.DTO;

namespace exercise_api.Data
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            this.CreateMap<Exercise, ExerciseDto>();
        }
        
    }
}
