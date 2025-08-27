using CV.BE.API.Models.DTOs.Testimonials;
using CV.BE.API.Models.Responses;
using CV.BE.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class TestimonialController : ControllerBase
    {
        private readonly ILogger<TestimonialController> _logger;
        private readonly ITestimonialService _service;

        public TestimonialController(ILogger<TestimonialController> logger, ITestimonialService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTestimonialsAsync()
        {
            var result = await _service.GetAllAsync();
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonialAsync(TestimonialDto dto)
        {
            var result = await _service.CreateAsync(dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonialAsync(Guid id, TestimonialDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonialAsync(Guid id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }
    }
}


