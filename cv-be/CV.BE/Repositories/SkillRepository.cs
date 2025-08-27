using CV.BE.Domains;
using CV.BE.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.Repositories
{
    public interface ISkillRepository
    {
        Task<List<Skill>> GetAllAsync();
        Task<Skill> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Skill entity);
        Task<bool> UpdateAsync(Skill entity);
    }

    public class SkillRepository : ISkillRepository
    {
        private readonly IDatabaseContext _dbContext;

        public SkillRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Skill>> GetAllAsync()
        {
            return await _dbContext.Skills.Include(x => x.SkillCategory).ToListAsync();
        }

        public async Task<Skill> GetByIdAsync(Guid id)
        {
            return await _dbContext.Skills.Include(x => x.SkillCategory).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Skill entity)
        {
            _dbContext.Skills.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(Skill entity)
        {
            _dbContext.Skills.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


