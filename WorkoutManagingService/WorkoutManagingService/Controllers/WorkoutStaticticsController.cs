using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutManagingService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkoutStaticticsController : ControllerBase
    {
        [HttpGet]
        [Authorize("Admin")]
        public async Task Get() { }

        [HttpGet]
        [Authorize("Admin")]
        public async Task Get(string username) { }


    }
}