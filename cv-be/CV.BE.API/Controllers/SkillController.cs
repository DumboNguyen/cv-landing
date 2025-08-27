using CV.BE.API.Models.DTOs.Skills;
using CV.BE.API.Models.Responses;
using CV.BE.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class SkillController : ControllerBase
    {
        private readonly ILogger<SkillController> _logger;
        private readonly ISkillService _skillService;
        private readonly ISkillCategoryService _skillCategoryService;

        public SkillController(ILogger<SkillController> logger, ISkillService skillService, ISkillCategoryService skillCategoryService)
        {
            _logger = logger;
            _skillService = skillService;
            _skillCategoryService = skillCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSkillsAsync()
        {
            var result = await _skillService.GetAllAsync();
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        [Route("category")]
        public async Task<IActionResult> CreateSkillCategoryAsync(SkillCategoryDto dto)
        {
            var result = await _skillCategoryService.CreateAsync(dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpGet]
        [Route("category")]
        public async Task<IActionResult> GetSkillCategoriesAsync()
        {
            var result = await _skillCategoryService.GetAllAsync();
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkillAsync(SkillDto dto)
        {
            var result = await _skillService.CreateAsync(dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSkillAsync(Guid id, SkillDto dto)
        {
            var result = await _skillService.UpdateAsync(id, dto);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSkillAsync(Guid id)
        {
            var result = await _skillService.DeleteAsync(id);
            if (!result.IsSuccess) return ResponseFactory.Fail(result.Error);
            return ResponseFactory.Success();
        }
    }
}
