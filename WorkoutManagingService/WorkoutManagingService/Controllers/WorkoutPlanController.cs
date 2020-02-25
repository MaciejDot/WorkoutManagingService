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

        [HttpGet("{WorkoutId}")]
        [Authorize]
        public async Task<ActionResult<WorkoutPlanDTO>> Get(int WorkoutId, CancellationToken token)
        {
            try
            {
                return await _mediator.Send(new GetUserWorkoutPlanQuery { UserId = User.Claims.Single(x => x.Type == "Id").Value, WorkoutPlanId = WorkoutId }, token);
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

        [HttpDelete("{WorkoutId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int WorkoutId, CancellationToken token)
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
            return Ok();
        }

        [HttpPut("{WorkoutId}")]
        [Authorize]
        public async Task<IActionResult> Put(int WorkoutId, bool IsPublic, CancellationToken token)
        {
            if (!await _mediator.Send(new IsUserWorkoutPlanOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = WorkoutId
            }, token))
            {
                return Unauthorized();
            }

            await _mediator.Send(new UpdateWorkoutPlanStatusCommand
            {
                IsPublic = IsPublic,
                WorkoutId = WorkoutId,
            }, token);
            return Ok();
        }


        [HttpPatch("{WorkoutId}")]
        [Authorize]
        public async Task<IActionResult> Patch(int WorkoutId, WorkoutPlanModel request, CancellationToken token)
        {
            if (!await _mediator.Send(new IsUserWorkoutPlanOwnerQuery
            {
                UserId = User.Claims.Single(x => x.Type == "Id").Value,
                WorkoutId = WorkoutId
            }, token))
            {
                return Unauthorized();
            }
            await _mediator.Send(new UpdateWorkoutPlanCommand
            {
                WorkoutId = WorkoutId,
                Name = request.Name,
                Description = request.Description,
                Exercises = request.Exercises
            },
            token);
            return Ok();
        }

    }
}