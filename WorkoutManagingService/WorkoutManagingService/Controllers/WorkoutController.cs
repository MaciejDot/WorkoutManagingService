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

        [HttpPatch("{workoutId}")]
        [Authorize]
        public async Task<IActionResult> Patch(int workoutId, [FromBody] WorkoutModel model, CancellationToken token) {
            if (!await _mediator.Send(new IsUserWorkoutOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = workoutId
            }, token))
            {
                return Unauthorized();
            }
            await _mediator.Send(new UpdateWorkoutCommand
            {
                WorkoutId = workoutId,
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                Description = model.Description,
                MoodLevel = (MoodLevelEnum) model.Mood,
                FatigueLevel = (FatigueLevelEnum) model.Fatigue,
                ExecutionTime = model.DateOfWorkout,
                ExerciseExecutions = model.Exercises,
                WorkoutName = model.Name
            }, token);
            return Ok();
        }

        [HttpDelete("{workoutId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int workoutId, CancellationToken token) {
            if (!await _mediator.Send(new IsUserWorkoutOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = workoutId
            }, token))
            {
                return Unauthorized();
            }
            await _mediator.Send(new DeleteWorkoutCommand { WorkoutId = workoutId }, token);
            return Ok();
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<WorkoutThumbnailDTO>>> Get(CancellationToken token) {
            return await _mediator.Send(
                new GetUserWorkoutsQuery{ UserId = User.Claims.Single(x => x.Type == "Id").Value });
        }

        [HttpGet("{workoutId}")]
        [Authorize]
        public async Task<ActionResult<WorkoutDTO>> Get(int workoutId, CancellationToken token) {
            try
            {
               return await _mediator.Send(new GetUserWorkoutQuery { 
                   UserId = User.Claims.Single(x => x.Type == "Id").Value, 
                   WorkoutId = workoutId }, token);
            }
            catch
            {
                return NotFound();
            }
        }

    }
}