using CV.BE.API.Domains;
using CV.BE.API.Models.DTOs;
using CV.BE.API.Models.DTOs.Educations;
using CV.BE.API.Repositories;
using Mapster;

namespace CV.BE.API.Services
{
    public interface IEducationService
    {
        Task<ServiceResult<List<EducationDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(EducationDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, EducationDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class EducationService : IEducationService
    {
        private readonly IEducationRepository _repo;

        public EducationService(IEducationRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<EducationDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<EducationDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(EducationDto dto)
        {
            var entity = Education.Create(dto.SchoolName, dto.Location, dto.StudyStartTime, dto.StudyEndTime, dto.Degree, dto.Descriptions);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, EducationDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");

            entity.Update(dto.SchoolName, dto.Location, dto.StudyStartTime, dto.StudyEndTime, dto.Degree, dto.Descriptions);
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


