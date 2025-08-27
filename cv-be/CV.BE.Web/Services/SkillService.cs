using CV.BE.Web.Domains;
using CV.BE.Web.Models.DTOs;
using CV.BE.Web.Models.DTOs.Skills;
using CV.BE.Web.Repositories;
using Mapster;

namespace CV.BE.Web.Services
{
    public interface ISkillService
    {
        Task<ServiceResult<List<SkillDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(SkillDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, SkillDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public interface ISkillCategoryService
    {
        Task<ServiceResult<List<SkillCategoryDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(SkillCategoryDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, SkillCategoryDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _repo;

        public SkillService(ISkillRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<SkillDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<SkillDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(SkillDto dto)
        {
            var entity = Skill.Create(dto.Name, dto.ProficiencyPercent, dto.SkillCategoryId);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, SkillDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.Update(dto.Name, dto.ProficiencyPercent, dto.SkillCategoryId);
            var ok = await _repo.UpdateAsync(entity);
            return ok ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }

        public async Task<ServiceResult> DeleteAsync(Guid id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.SoftDelete();
            var ok = await _repo.UpdateAsync(entity);
            return ok ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }
    }

    public class SkillCategoryService : ISkillCategoryService
    {
        private readonly ISkillCategoryRepository _repo;

        public SkillCategoryService(ISkillCategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<SkillCategoryDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<SkillCategoryDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(SkillCategoryDto dto)
        {
            var entity = new SkillCategory
            {
                Name = dto.Name,
                CreatedDate = DateTime.UtcNow
            };
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, SkillCategoryDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.Name = dto.Name;
            entity.UpdatedDate = DateTime.UtcNow;
            var ok = await _repo.UpdateAsync(entity);
            return ok ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }

        public async Task<ServiceResult> DeleteAsync(Guid id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.UtcNow;
            var ok = await _repo.UpdateAsync(entity);
            return ok ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }
    }
}


