
namespace CV.BE.Domains
{
    public class Contact : BaseDomain
    {
        public Contact()
        {
            
        }

        public static Contact Create(string email, string phone, string linkedIn, string gitHub)
        {
            return new Contact
            {
                Email = email,
                Phone = phone,
                LinkedIn = linkedIn,
                GitHub = gitHub,
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string email, string phone, string linkedIn, string gitHub)
        {
            Email = email;
            Phone = phone;
            LinkedIn = linkedIn;
            GitHub = gitHub;
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
    }
}
