using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.Domain.Command;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;
using WorkoutManagingService.Models;

namespace WorkoutManagingService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkoutPlanController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WorkoutPlanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<WorkoutPlanThumbnailDTO>>> Get(CancellationToken token)
        {
            return await _mediator.Send(new GetUserWorkoutPlansQuery { UserId = User.Claims.Single(x => x.Type == "Id").Value }, token);
        }

        [HttpGet("{username}/{workoutName}")]
        [AllowAnonymous]
        public async Task<ActionResult<WorkoutPlanDTO>> Get(string username, string workoutName, CancellationToken token)
        {
            try
            {
                return await _mediator.Send(new GetUserWorkoutPlanQuery
                {
                    RequesterId = User?.Claims?.FirstOrDefault(x => x.Type == "Id")?.Value,
                    Username = username,
                    WorkoutPlanName = workoutName
                }, token);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(WorkoutPlanModel request, CancellationToken token)
        {
            await _mediator.Send(new CreateWorkoutPlanCommand()
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                Name = request.Name,
                Description = request.Description,
                Exercises = request.Exercises
            },
            token);
            return Ok();
        }

        [HttpDelete("{workoutName}")]
        [Authorize]
        public async Task<IActionResult> Delete(string workoutName, CancellationToken token)
        {
            await _mediator.Send(new DeleteWorkoutPlanCommand
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutName = workoutName
            }, token);
            return Ok();
        }

        [HttpPatch("{workoutName}")]
        [Authorize]
        public async Task<IActionResult> Patch(string workoutName, WorkoutPlanModel request, CancellationToken token)
        {
            await _mediator.Send(new UpdateWorkoutPlanCommand
            {
                WorkoutName = workoutName,
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                Exercises = request.Exercises
            },
            token);
            return Ok();
        }

    }
}