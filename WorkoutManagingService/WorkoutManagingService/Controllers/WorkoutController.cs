using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.Data.Enums;
using WorkoutManagingService.Domain.Command;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;
using WorkoutManagingService.Models;

namespace WorkoutManagingService.Controllers
{
    [Route("Workout")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkoutController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize]
        public Task Post([FromBody] WorkoutModel model, CancellationToken token) {
            return _mediator.Send(new CreateWorkoutCommand 
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                CreatedTime = DateTime.Now,
                Description = model.Description,
                MoodLevel = (MoodLevelEnum) model.Mood,
                FatigueLevel = (FatigueLevelEnum) model.Fatigue,
                ExecutionTime = model.DateOfWorkout,
                ExerciseExecutions = model.Exercises,
                WorkoutName = model.Name
            }, token);
        }

        [HttpPatch("{workoutName}")]
        [Authorize]
        public async Task<IActionResult> Patch(string workoutName, [FromBody] WorkoutModel model, CancellationToken token) {
            await _mediator.Send(new UpdateWorkoutCommand
            {
                WorkoutName = workoutName,
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                MoodLevel = (MoodLevelEnum) model.Mood,
                FatigueLevel = (FatigueLevelEnum) model.Fatigue,
                ExecutionTime = model.DateOfWorkout,
                ExerciseExecutions = model.Exercises
            }, token);
            return Ok();
        }

        [HttpDelete("{workoutName}")]
        [Authorize]
        public async Task<IActionResult> Delete(string workoutName, CancellationToken token) {
            await _mediator.Send(new DeleteWorkoutCommand { 
                WorkoutName = workoutName, 
                UserId = User.Claims.Single(x => x.Type == "Id").Value 
            }, token);
            return Ok();
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<WorkoutThumbnailDTO>>> Get(CancellationToken token) {
            return await _mediator.Send(
                new GetUserWorkoutsQuery{ UserId = User.Claims.Single(x => x.Type == "Id").Value });
        }

        [HttpGet("{username}/{workoutName}")]
        [AllowAnonymous]
        public async Task<ActionResult<WorkoutDTO>> Get(string username, string workoutName, CancellationToken token) {
            try
            {
               return await _mediator.Send(new GetUserWorkoutQuery { 
                   Username = username,
                   RequesterId = User?.Claims?.FirstOrDefault(x => x.Type == "Id")?.Value, 
                   WorkoutName = workoutName
               }, token);
            }
            catch
            {
                return NotFound();
            }
        }

    }
}