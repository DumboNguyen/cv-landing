using CV.BE.API.Domains;
using CV.BE.API.Infras;
using Microsoft.EntityFrameworkCore;

namespace CV.BE.API.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> GetAsync();
        Task<Contact> GetByIdAsync(Guid id);
        Task<Guid?> AddAsync(Contact contact);
        Task<bool> UpdateAsync(Contact contact);
    }

    public class ContactRepository : IContactRepository
    {
        private readonly IDatabaseContext _dbContext;

        public ContactRepository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Contact> GetAsync()
        {
            return await _dbContext.Contacts.FirstOrDefaultAsync();
        }

        public async Task<Contact> GetByIdAsync(Guid id)
        {
            return await _dbContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> AddAsync(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            var success = await _dbContext.SaveChangesAsync();

            if (success < 1)
            {
                return null;
            }

            return contact.Id;
        }

        public async Task<bool> UpdateAsync(Contact contact)
        {
            _dbContext.Contacts.Update(contact);
            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
