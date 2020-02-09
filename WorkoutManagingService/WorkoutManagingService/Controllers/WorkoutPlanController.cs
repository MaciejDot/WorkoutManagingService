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

        [HttpGet("/[WorkoutId]")]
        [Authorize]
        public async Task<ActionResult<List<WorkoutPlanThumbnailDTO>>> Get(int WorkoutId, CancellationToken token)
        {
            if (!await _mediator.Send(new IsUserWorkoutPlanOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = WorkoutId
            }, token))
            {
                return Unauthorized();
            }
            return await _mediator.Send(new GetUserWorkoutPlansQuery { UserId = User.Claims.Single(x => x.Type == "Id").Value }, token);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Post(WorkoutPlanModel request, CancellationToken token)
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

        [HttpDelete("/[WorkoutId]")]
        [Authorize]
        public async Task<ActionResult> Delete(int WorkoutId, CancellationToken token)
        {
            if (!await _mediator.Send(new IsUserWorkoutPlanOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = WorkoutId
            },token))
            {
                return Unauthorized();
            }
            await _mediator.Send(new DeleteWorkoutPlanCommand
            {
                WorkoutId = WorkoutId,
            },token);
            return Ok();
        }

        [HttpPut("/[WorkoutId]")]
        [Authorize]
        public async Task<ActionResult> Put(int WorkoutId, WorkoutPlanModel request, CancellationToken token)
        {
            if (!await _mediator.Send(new IsUserWorkoutPlanOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = WorkoutId
            }, token))
            {
                return Unauthorized();
            }
            await _mediator.Send(new DeleteWorkoutPlanCommand
            {
                WorkoutId = WorkoutId,
            }, token);
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

    }
}