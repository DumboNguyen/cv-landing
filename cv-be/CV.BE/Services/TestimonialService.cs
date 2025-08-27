using CV.BE.Web.Domains;
using CV.BE.Web.Models.DTOs;
using CV.BE.Web.Models.DTOs.Testimonials;
using CV.BE.Web.Repositories;
using Mapster;

namespace CV.BE.Web.Services
{
    public interface ITestimonialService
    {
        Task<ServiceResult<List<TestimonialDto>>> GetAllAsync();
        Task<ServiceResult<Guid>> CreateAsync(TestimonialDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, TestimonialDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _repo;

        public TestimonialService(ITestimonialRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<List<TestimonialDto>>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return ServiceResult.Success(data.Adapt<List<TestimonialDto>>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(TestimonialDto dto)
        {
            var entity = Testimonial.Create(dto.AuthorName, dto.Descriptions, dto.AuthorPosition);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, TestimonialDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");
            entity.Update(dto.AuthorName, dto.Descriptions, dto.AuthorPosition);
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


