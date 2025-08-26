using Microsoft.AspNetCore.Mvc;

namespace CV.BE.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ExperienceController> _logger;

        public ExperienceController(ILogger<ExperienceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task GetExperienceAsync()
        {

        }
    }
}
