using CV.BE.Domains;
using CV.BE.Models.DTOs.Personals;
using CV.BE.Models.Responses;
using CV.BE.Repositories;
using Mapster;

namespace CV.BE.Services
{
    public interface IPersonalService
    {
        Task<ServiceResult<PersonalDto>> GetAsync();
        Task<ServiceResult<Guid>> CreateAsync(PersonalDto dto);
        Task<ServiceResult> UpdateAsync(Guid id, PersonalDto dto);
        Task<ServiceResult> DeleteAsync(Guid id);
    }

    public class PersonalService : IPersonalService
    {
        private readonly IPersonalRepository _repo;

        public PersonalService(IPersonalRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult<PersonalDto>> GetAsync()
        {
            var data = await _repo.GetAsync();
            return ServiceResult.Success(data.Adapt<PersonalDto>());
        }

        public async Task<ServiceResult<Guid>> CreateAsync(PersonalDto dto)
        {
            var entity = Personal.Create(dto.FirstName, dto.LastName, dto.Title, dto.AboutMe);
            var id = await _repo.AddAsync(entity);
            if (id == null) return ServiceResult.Failure<Guid>("Create failed");
            return ServiceResult.Success(id.Value);
        }

        public async Task<ServiceResult> UpdateAsync(Guid id, PersonalDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return ServiceResult.Failure("Not found");

            entity.Update(dto.FirstName, dto.LastName, dto.Title, dto.AboutMe);
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


