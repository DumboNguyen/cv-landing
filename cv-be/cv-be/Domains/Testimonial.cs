
namespace CV.BE.Domains
{
    public class Testimonial : BaseDomain
    {
        public Testimonial()
        {
            
        }

        public string AuthorName { get; set; }
        public List<string> Descriptions { get; set; }
        public string AuthorPosition { get; set; }
    }
}
