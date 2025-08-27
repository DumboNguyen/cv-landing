using CV.BE.API.Domains;
using CV.BE.API.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.API.Repositories
{
    public interface IFeaturedProjectRepository
    {
        Task<List<FeaturedProject>> GetAllAsync();
        Task<FeaturedProject> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(FeaturedProject entity);
        Task<bool> UpdateAsync(FeaturedProject entity);
    }

    public class FeaturedProjectRepository : IFeaturedProjectRepository
    {
        private readonly IDatabaseContext _dbContext;

        public FeaturedProjectRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FeaturedProject>> GetAllAsync()
        {
            return await _dbContext.FeaturedProjects.ToListAsync();
        }

        public async Task<FeaturedProject> GetByIdAsync(Guid id)
        {
            return await _dbContext.FeaturedProjects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(FeaturedProject entity)
        {
            _dbContext.FeaturedProjects.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(FeaturedProject entity)
        {
            _dbContext.FeaturedProjects.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


