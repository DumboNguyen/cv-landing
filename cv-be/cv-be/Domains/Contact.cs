
namespace CV.BE.Domains
{
    public class Contact : BaseDomain
    {
        public Contact()
        {
            
        }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
    }
}
