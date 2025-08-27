using CV.BE.API.Domains;
using CV.BE.API.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.API.Repositories
{
    public interface IExperienceRepository
    {
        Task<List<Experience>> GetAllAsync();
        Task<Experience> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Experience entity);
        Task<bool> UpdateAsync(Experience entity);
    }

    public class ExperienceRepository : IExperienceRepository
    {
        private readonly IDatabaseContext _dbContext;

        public ExperienceRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Experience>> GetAllAsync()
        {
            return await _dbContext.Experiences.ToListAsync();
        }

        public async Task<Experience> GetByIdAsync(Guid id)
        {
            return await _dbContext.Experiences.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Experience entity)
        {
            _dbContext.Experiences.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(Experience entity)
        {
            _dbContext.Experiences.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


