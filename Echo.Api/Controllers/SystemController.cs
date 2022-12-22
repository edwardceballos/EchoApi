using Microsoft.AspNetCore.Mvc;

namespace Echo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : ControllerBase
    {
      

        private readonly ILogger<SystemController> _logger;

        public SystemController(ILogger<SystemController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Date")]
        public ActionResult Get()
        {
            return Ok(new { date = System.DateTime.Now, utc=System.DateTime.UtcNow,unix= DateTimeOffset.Now.ToUnixTimeSeconds() });
        }
    }
}