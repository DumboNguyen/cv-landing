using CV.BE.API.Domains;
using CV.BE.API.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.API.Repositories
{
    public interface ISkillCategoryRepository
    {
        Task<List<SkillCategory>> GetAllAsync();
        Task<SkillCategory> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(SkillCategory entity);
        Task<bool> UpdateAsync(SkillCategory entity);
    }

    public class SkillCategoryRepository : ISkillCategoryRepository
    {
        private readonly IDatabaseContext _dbContext;

        public SkillCategoryRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillCategory>> GetAllAsync()
        {
            return await _dbContext.SkillCategories.Include(x => x.Skills).ToListAsync();
        }

        public async Task<SkillCategory> GetByIdAsync(Guid id)
        {
            return await _dbContext.SkillCategories.Include(x => x.Skills).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(SkillCategory entity)
        {
            _dbContext.SkillCategories.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(SkillCategory entity)
        {
            _dbContext.SkillCategories.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


