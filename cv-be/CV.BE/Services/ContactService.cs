using CV.BE.Web.Domains;
using CV.BE.Web.Models.DTOs;
using CV.BE.Web.Models.DTOs.Contacts;
using CV.BE.Web.Repositories;
using Mapster;

namespace CV.BE.Web.Services
{
    public interface IContactService
    {
        Task<ServiceResult<ContactDto>> GetContactAsync();
        Task<ServiceResult<Guid>> CreateContactAsync(ContactDto dto);
        Task<ServiceResult> UpdateContactAsync(Guid id, ContactDto dto);
        Task<ServiceResult> DeleteContactAsync(Guid id);
    }

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ServiceResult<ContactDto>> GetContactAsync()
        {
            var data = await _contactRepository.GetAsync();
            return ServiceResult.Success(data.Adapt<ContactDto>());
        }

        public async Task<ServiceResult<Guid>> CreateContactAsync(ContactDto dto)
        {
            var contact = Contact.Create(dto.Email, dto.Phone, dto.LinkedIn, dto.GitHub);
            var data = await _contactRepository.AddAsync(contact);

            if (data == null)
            {
                return ServiceResult.Failure<Guid>("Create failed");
            }

            return ServiceResult.Success(data.Value);
        }

        public async Task<ServiceResult> UpdateContactAsync(Guid id, ContactDto dto)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            if (contact == null)
            {
                return ServiceResult.Failure("Not found");
            }

            contact.Update(dto.Email, dto.Phone, dto.LinkedIn, dto.GitHub);
            var data = await _contactRepository.UpdateAsync(contact);

            return data ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }

        public async Task<ServiceResult> DeleteContactAsync(Guid id)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            if (contact == null)
            {
                return ServiceResult.Failure("Not found");
            }

            contact.SoftDelete();
            var data = await _contactRepository.UpdateAsync(contact);

            return data ? ServiceResult.Success() : ServiceResult.Failure("fail");
        }
    }
}
