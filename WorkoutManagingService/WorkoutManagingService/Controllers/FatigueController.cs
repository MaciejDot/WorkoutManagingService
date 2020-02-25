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
    public class FatigueController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get() {
        
        }
    }
}