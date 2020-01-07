using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutManagingService.Controllers
{
    [Route("Plan")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        /// <summary>
        /// Post new plan
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task Post() { }

        /// <summary>
        /// Edit plan
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Authorize]
        public async Task Patch() { }

        /// <summary>
        /// Get twenty plans of other public users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(int page) { }

        /// <summary>
        /// Get specific plan
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task Get(int page, string workout) { }
    }
}