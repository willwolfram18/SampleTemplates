using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<WeatherForecast> Get() => GenerateRandomWeatherForecast(5);

        [HttpGet]
        [MapToApiVersion("2.0")]
        public ActionResult<IEnumerable<WeatherForecast>> GetV2() => Ok(GenerateRandomWeatherForecast(7));

        private static IEnumerable<WeatherForecast> GenerateRandomWeatherForecast(int numEntries)
        {
            var rng = new Random();
            return Enumerable.Range(1, numEntries).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
