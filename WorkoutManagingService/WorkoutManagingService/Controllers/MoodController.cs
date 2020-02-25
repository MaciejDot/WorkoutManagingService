using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoodController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ActionResult<IEnumerable<MoodLevelDTO>>> Get(CancellationToken token)
        {
            return Ok(await _mediator.Send(new GetMoodLevelsQuery(),token));
        }
    }
}