using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HelloLinux.Controllers
{
    [ApiController]
    [Route("Hello")]
    public class SpeechController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(string),(int)HttpStatusCode.OK)]
        public IActionResult SayHello()
        {
            return new ObjectResult("Hello World!");
        }
    }
}
