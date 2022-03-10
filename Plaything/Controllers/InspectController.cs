namespace PlaythingV2.Controllers
{
    using System.Collections.Generic;
    using System.Text.Json;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class InspectController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        public InspectController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Dictionary<string, string> payload)
        {
            _logger.LogInformation("Method: {0}", Request.Method);
            _logger.LogInformation("Body: {0}", JsonSerializer.Serialize(payload));
            _logger.LogInformation("Content-length: {0}", JsonSerializer.Serialize(Request.Headers.ContentLength));
            return new OkResult();
        }
    }
}
