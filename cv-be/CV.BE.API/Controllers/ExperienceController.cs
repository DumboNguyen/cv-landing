using CV.BE.API.Models.DTOs.Experiences;
using CV.BE.API.Models.Responses;
using CV.BE.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class ExperienceController : ControllerBase
    {
        private readonly ILogger<ExperienceController> _logger;
        private readonly IExperienceService _service;

        public ExperienceController(ILogger<ExperienceController> logger, IExperienceService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetExperienceAsync()
        {
            var result = await _service.GetAllAsync();
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExperienceAsync(ExperienceDto request)
        {
            var result = await _service.CreateAsync(request);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateExperienceAsync(Guid id, ExperienceDto request)
        {
            var result = await _service.UpdateAsync(id, request);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteExperienceAsync(Guid id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success();
        }
    }
}
