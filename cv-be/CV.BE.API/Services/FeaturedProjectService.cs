using CV.BE.API.Domains;
using CV.BE.API.Models.DTOs;
using CV.BE.API.Models.DTOs.FeaturedProjects;
using CV.BE.API.Repositories;
using Mapster;

namespace CV.BE.API.Services
{
    public interface IFeaturedProjectService
    {
        Task<ServiceResult<List<FeaturedProjectDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(FeaturedProjectDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, FeaturedProjectDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class FeaturedProjectService : IFeaturedProjectService
    {
        private readonly IFeaturedProjectRepository _repo;

        public FeaturedProjectService(IFeaturedProjectRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<FeaturedProjectDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<FeaturedProjectDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(FeaturedProjectDto dto)
        {
            var entity = FeaturedProject.Create(dto.Name, dto.Descriptions, dto.Link, dto.Technologies, dto.ImageUrl);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, FeaturedProjectDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.Update(dto.Name, dto.Descriptions, dto.Link, dto.Technologies, dto.ImageUrl);
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


