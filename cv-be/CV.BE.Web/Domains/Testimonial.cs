namespace CV.BE.Web.Domains
{
    public class Testimonial : BaseDomain
    {
        public Testimonial()
        {

        }

        public static Testimonial Create(string authorName, List<string> descriptions, string authorPosition)
        {
            return new Testimonial
            {
                AuthorName = authorName,
                Descriptions = descriptions ?? new List<string>(),
                AuthorPosition = authorPosition,
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string authorName, List<string> descriptions, string authorPosition)
        {
            AuthorName = authorName;
            Descriptions = descriptions ?? new List<string>();
            AuthorPosition = authorPosition;
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string AuthorName { get; set; }
        public List<string> Descriptions { get; set; }
        public string AuthorPosition { get; set; }
    }
}
