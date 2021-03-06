﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FatigueController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FatigueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<FatigueLevelDTO>>> Get(CancellationToken token) {
            return Ok(await _mediator.Send(new GetFatiguesLevelsQuery(), token));
        }
    }
}