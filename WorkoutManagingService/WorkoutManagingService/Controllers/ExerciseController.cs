using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutManagingService.DTO;

namespace WorkoutManagingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        /// <summary>
        /// Post new Exercise (Possible abuse) //
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize("Admin")]
        public async Task Post() { }

        /// <summary>
        /// Edit exercise (Possible abuse) //
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Authorize("Admin")]
        public async Task Patch() { }

        /// <summary>
        /// Get All Exercises
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<IEnumerable<ExerciseDTO>>> Get(CancellationToken token) {
            await Task.CompletedTask;
            return new List<ExerciseDTO> { new ExerciseDTO { Id = 1, Name = "Planche" } };
        }
    }
}