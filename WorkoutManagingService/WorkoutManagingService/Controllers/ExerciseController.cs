using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.Data.Seed;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Controllers
{

    [EnableCors]
    [Route("Exercise")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<ExerciseDTO>>> Get(CancellationToken token = default(CancellationToken))
        {
            return await _mediator.Send(new GetExercisesQuery(), token);
        }
    }
}