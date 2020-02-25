using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutManagingService.Controllers
{
    [Route("Workout")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        /// <summary>
        /// Post Day of workout or free day
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task Post(CancellationToken token) { }

        /// <summary>
        /// Edit Day of workout or free day
        /// </summary>
        /// <returns></returns>
        [HttpPatch("{workoutId}")]
        [Authorize]
        public async Task<IActionResult> Patch(int workoutId, CancellationToken token) {
            return Unauthorized();
        }

        [HttpPut("{workoutId}")]
        [Authorize]
        public async Task<IActionResult> Put(int workoutId, CancellationToken token) {
            return Unauthorized();
        }

        [HttpDelete("{workoutId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int workoutId, CancellationToken token) {
            return Unauthorized();
        }
        /// <summary>
        /// Get twenty workout per page or sooo...
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(CancellationToken token) { }

        /// <summary>
        /// Get specific workout
        /// </summary>
        /// <returns></returns>
        [HttpGet("{workoutId}")]
        [Authorize]
        public async Task Get(int workoutId, CancellationToken token) { }


        //Delete?

    }
}