using CV.BE.API.Models.DTOs.FeaturedProjects;
using CV.BE.API.Models.Responses;
using CV.BE.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class FeaturedProjectController : ControllerBase
    {
        private readonly ILogger<FeaturedProjectController> _logger;
        private readonly IFeaturedProjectService _service;

        public FeaturedProjectController(ILogger<FeaturedProjectController> logger, IFeaturedProjectService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeaturedProjectsAsync()
        {
            var result = await _service.GetAllAsync();
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeaturedProjectAsync(FeaturedProjectDto dto)
        {
            var result = await _service.CreateAsync(dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeaturedProjectAsync(Guid id, FeaturedProjectDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeaturedProjectAsync(Guid id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }
    }
}


