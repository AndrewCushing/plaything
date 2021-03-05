namespace Plaything.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {
        private readonly ILogger<CodeController> _logger;

        public CodeController(ILogger<CodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{statusCode}")]
        public IActionResult Get(int statusCode)
        {
            _logger.LogInformation("Responding with status code {statusCode}", statusCode);
            return new StatusCodeResult(statusCode);
        }
    }
}