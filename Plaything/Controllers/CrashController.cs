namespace Plaything.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    
    [ApiController]
    [Route("[controller]")]
    public class CrashController : ControllerBase
    {
        private readonly ILogger<CrashController> _logger;

        public CrashController(ILogger<CrashController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogCritical("Dying!!!");
            Environment.Exit(666);
            return Ok();
        }
    }
}