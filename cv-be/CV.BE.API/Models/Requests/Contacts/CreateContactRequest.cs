using CV.BE.API.Models.DTOs.Contacts;

namespace CV.BE.API.Models.Requests.Contacts
{
    public class CreateContactRequest
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
    }

    public static class CreateContactRequestExtensions
    {
        public static ContactDto ToDto(this CreateContactRequest request)
        {
            if (request == null) return null;

            return new ContactDto
            {
                Email = request.Email,
                Phone = request.Phone,
                LinkedIn = request.LinkedIn,
                GitHub = request.GitHub
            };
        }
    }
}
