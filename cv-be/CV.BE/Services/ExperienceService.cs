using CV.BE.Domains;
using CV.BE.Models.DTOs.Experiences;
using CV.BE.Models.Responses;
using CV.BE.Repositories;
using Mapster;

namespace CV.BE.Services
{
    public interface IExperienceService
    {
        Task<ServiceResult<List<ExperienceDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(ExperienceDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, ExperienceDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _repo;

        public ExperienceService(IExperienceRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<ExperienceDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<ExperienceDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(ExperienceDto dto)
        {
            var entity = Experience.Create(dto.CompanyName, dto.Location, dto.WorkStartTime, dto.WorkEndTime, dto.Level, dto.Descriptions);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, ExperienceDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");

            entity.Update(dto.CompanyName, dto.Location, dto.WorkStartTime, dto.WorkEndTime, dto.Level, dto.Descriptions);
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
}


