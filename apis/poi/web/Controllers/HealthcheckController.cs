using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using poi.Models;
using poi.Data;
using poi.Utility;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace poi.Controllers
{
    [Produces("application/json")]
    [Route("api/healthcheck/poi")]
    public class HealthCheckController : ControllerBase
    {

        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;

        public HealthCheckController(ILogger<HealthCheckController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(Healthcheck))]
        public IActionResult Get()
        {
            _logger.LogInformation(LoggingEvents.Healthcheck, "Healthcheck Not Requested :)");
            return Ok(new Healthcheck { Version = _configuration["version"] });
        }
    }

}