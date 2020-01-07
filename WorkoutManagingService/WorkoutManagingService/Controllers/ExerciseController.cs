using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        /// search for exercise
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(string queryExercise, int page) { }

        /// <summary>
        /// Get exercise by pages
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(int page) { }

        /// <summary>
        /// Get All Exercises
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get() { }

        /// <summary>
        /// Get All Exercises by category/kind
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(string kind) { }
    }
}