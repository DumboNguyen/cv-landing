using CV.BE.Web.Models.DTOs.Contacts;

namespace CV.BE.Web.Models.Requests.Contacts
{
    public class UpdateContactRequest
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
    }

    public static class UpdateContactRequestExtensions
    {
        public static ContactDto ToDto(this UpdateContactRequest request)
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
