using CV.BE.Domains;
using CV.BE.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.Repositories
{
    public interface IEducationRepository
    {
        Task<List<Education>> GetAllAsync();
        Task<Education> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Education entity);
        Task<bool> UpdateAsync(Education entity);
    }

    public class EducationRepository : IEducationRepository
    {
        private readonly IDatabaseContext _dbContext;

        public EducationRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Education>> GetAllAsync()
        {
            return await _dbContext.Educations.ToListAsync();
        }

        public async Task<Education> GetByIdAsync(Guid id)
        {
            return await _dbContext.Educations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Education entity)
        {
            _dbContext.Educations.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(Education entity)
        {
            _dbContext.Educations.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


