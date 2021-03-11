namespace Plaything.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class EnvController
    {
        private readonly ILogger<EnvController> _logger;

        public EnvController(ILogger<EnvController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Someone wants to see all my environment variables. Who am I to argue?");
            var env = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();
            return new OkObjectResult(env.AsEnumerable());
        }
    }
}