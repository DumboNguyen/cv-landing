using CV.BE.Domains;
using CV.BE.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.Repositories
{
    public interface ITestimonialRepository
    {
        Task<List<Testimonial>> GetAllAsync();
        Task<Testimonial> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Testimonial entity);
        Task<bool> UpdateAsync(Testimonial entity);
    }

    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDatabaseContext _dbContext;

        public TestimonialRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Testimonial>> GetAllAsync()
        {
            return await _dbContext.Testimonials.ToListAsync();
        }

        public async Task<Testimonial> GetByIdAsync(Guid id)
        {
            return await _dbContext.Testimonials.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Testimonial entity)
        {
            _dbContext.Testimonials.Add(entity);
            var success = await _dbContext.SaveChangesAsync();
            if (success < 1) return null;
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(Testimonial entity)
        {
            _dbContext.Testimonials.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}


