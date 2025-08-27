using CV.BE.API.Models.DTOs.Personals;
using CV.BE.API.Models.Responses;
using CV.BE.API.Services;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class PersonalController : ControllerBase
    {
        private readonly ILogger<PersonalController> _logger;
        private readonly IPersonalService _service;

        public PersonalController(ILogger<PersonalController> logger, IPersonalService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersonalAsync()
        {
            var result = await _service.GetAsync();
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonalAsync(PersonalDto dto)
        {
            var result = await _service.CreateAsync(dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePersonalAsync(Guid id, PersonalDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersonalAsync(Guid id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }
    }
}


