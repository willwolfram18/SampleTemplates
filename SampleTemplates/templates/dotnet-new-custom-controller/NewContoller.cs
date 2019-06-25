using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SampleTemplates.templates.dotnetnewcustomcontroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewContoller : ControllerBase
    {
        private readonly ILogger<NewContoller> _log;

        public NewContoller(ILogger<NewContoller> log)
        {
            _log = log;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new[] { "Custom value 1", "Custom value 2" });
        }
    }
}
