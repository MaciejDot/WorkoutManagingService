using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task Post() { }

        /// <summary>
        /// Edit Day of workout or free day
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Authorize]
        public async Task Patch() { }

        /// <summary>
        /// Get twenty workout per page or sooo...
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(int page) { }

        /// <summary>
        /// Get specific workout
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(int page, string workout) { }


        //Delete?

    }
}