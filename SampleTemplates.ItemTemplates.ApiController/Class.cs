using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
    [Route("api/[controller]")]
    class $safeitemrootname$ : ControllerBase
	{
        private readonly ILogger<$safeitemrootname$> _log;

        public $safeitemrootname$(ILogger<$safeitemrootname$> log)
        {
            _log = log;
        }

        public ActionResult Get()
        {
            _log.LogInformation("Details");

            return Ok(new[] { "Custom values 1", "Custom values 2" });
        }
	}
}
