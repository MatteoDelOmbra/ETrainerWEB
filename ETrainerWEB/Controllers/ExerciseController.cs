﻿using System.Threading.Tasks;
using ETrainerWEB.Models.DTO;
using ETrainerWEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETrainerWEB.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[action]")]
    public class ExerciseController : ControllerBase
    {
        private readonly ExerciseService _exerciseService;
        public ExerciseController(ExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }
        //Get exercise by id 
        [HttpGet("{exerciseId:int}")]
        public async Task<IActionResult> Exercise([FromRoute]int exerciseId)
        {
            var result = await _exerciseService.GetExerciseById(exerciseId);
            if(result != null)
                return Ok(result);
            return NotFound();
        }
        //Add new exercise 
        [HttpPost]
        public async Task<IActionResult> Exercise([FromBody] ExerciseDTO exercise)
        {
            var result = await _exerciseService.AddExercise(exercise);
            if(result != 0) 
                return Ok(result);
            return NotFound();
        }
        //Edit exercise
        [HttpPut]
        public async Task<IActionResult> EditExercise([FromBody] ExerciseDTO exercise)
        {
            var result = await _exerciseService.EditExercise(exercise);
            if (result)
                return Ok();
            return NotFound();
        }
        //Delete exercise
        [HttpDelete("{exerciseId:int}")]
        public IActionResult DeleteExercise([FromRoute]int exerciseId)
        {
            var result = _exerciseService.DeleteExercise(exerciseId).Result;
            if (result)
                return Ok();
            return NotFound();
        }
    }
}
