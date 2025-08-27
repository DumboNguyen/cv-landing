using CV.BE.API.Domains;
using CV.BE.API.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.API.Repositories
{
    public interface IPersonalRepository
    {
        Task<Personal> GetAsync();
        Task<Personal> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Personal entity);
        Task<bool> UpdateAsync(Personal entity);
    }

    public class PersonalRepository : IPersonalRepository
    {
        private readonly IDatabaseContext _dbContext;

        public PersonalRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Personal> GetAsync()
        {
            return await _dbContext.Personals.FirstOrDefaultAsync();
        }

        public async Task<Personal> GetByIdAsync(Guid id)
        {
            return await _dbContext.Personals.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Personal entity)
        {
            _dbContext.Personals.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(Personal entity)
        {
            _dbContext.Personals.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


