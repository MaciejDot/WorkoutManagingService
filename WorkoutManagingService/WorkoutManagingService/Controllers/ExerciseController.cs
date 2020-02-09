﻿using System;
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
        // [Authorize]
        public async Task<ActionResult<List<ExerciseDTO>>> Get(CancellationToken token = default(CancellationToken))
        {
            return await _mediator.Send(new GetExercisesQuery(), token);
        }
        /*
        [HttpGet]
        // [Authorize]
        public  ActionResult<string> Get()
        {
            return String.Join("", new GroupOfExerciseSeed().GroupsOfExercises().ToList().Select(x =>
             $"\n\n#region {x.Name}\n\n{String.Join("\n", new ExerciseSeed().Exercises().Where(y => (y.Id - x.Id*100) > -1 && (y.Id - x.Id*100) < 100).Select(y => $"yield return new Exercise {{ Id = {y.Id}, Name = \"{y.Name}\", IsHold = {y.IsHold.ToString().ToLower()}, GroupId = {x.Id}}};"))}\n\n#endregion")
            );
        }
        */
        /*
        [HttpGet]
       // [Authorize]
        public async Task<ActionResult<IEnumerable<ExerciseDTO>>> Get(CancellationToken token) {
            await Task.CompletedTask;
           // return new ExerciseSeed().Exercises().AsParallel().Select(x => new ExerciseDTO { Id = 1, Name = x.Name }).ToList();
        }*/
    }
}