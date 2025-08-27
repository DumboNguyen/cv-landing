using CV.BE.Models.DTOs.Educations;
using CV.BE.Models.Responses;
using CV.BE.Services;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class EducationController : ControllerBase
    {
        private readonly ILogger<EducationController> _logger;
        private readonly IEducationService _service;

        public EducationController(ILogger<EducationController> logger, IEducationService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetEducationAsync()
        {
            var result = await _service.GetAllAsync();
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEducationAsync(EducationDto request)
        {
            var result = await _service.CreateAsync(request);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEducationAsync(Guid id, EducationDto request)
        {
            var result = await _service.UpdateAsync(id, request);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEducationAsync(Guid id)
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
