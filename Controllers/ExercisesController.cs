﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using exercise_api;
using exercise_api.ExerciseContext;
using exercise_api.Repository;
using exercise_api.Service;
using AutoMapper;
using exercise_api.DTO;

namespace exercise_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly ExerciseDbContext _context;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IExerciseService _exerciseService;
        private readonly IMapper _mapper;

        public ExercisesController(ExerciseDbContext context, IExerciseRepository exerciseRepository, IExerciseService _exerciseService, IMapper mapper)
        {
            this._context = context;
            this._exerciseRepository = exerciseRepository;
            this._exerciseService = _exerciseService;
            this._mapper = mapper;
        }

        // GET: api/Exercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetExercises()
        {
            return await _context.Exercises.ToListAsync();
        }

        // GET: api/Exercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercise>> GetExercise(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return exercise;
        }

        [HttpGet("by-workout-type/{workouttype}")]

        public async Task<ActionResult<List<ExerciseDto>>> GetExercisesByWorkoutTypeAsync(string workouttype)
        {
            var exerciseList = await _exerciseService.GetExercisesByWorkoutTypeAsync(workouttype);
            List<ExerciseDto> results =  _mapper.Map<List<ExerciseDto>>(exerciseList);
            return results;
        }

        // POST: api/Exercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exercise>> PostExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercise", new { id = exercise.ExerciseId }, exercise);
        }

        // DELETE: api/Exercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }

            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExerciseExists(int id)
        {
            return _context.Exercises.Any(e => e.ExerciseId == id);
        }
    }
}
