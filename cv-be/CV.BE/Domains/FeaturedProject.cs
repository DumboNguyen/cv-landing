
namespace CV.BE.Domains
{
    public class FeaturedProject : BaseDomain
    {
        public FeaturedProject()
        {
            Technologies = new List<string>();
        }

        public static FeaturedProject Create(string name, List<string> descriptions, string link, List<string> technologies, string imageUrl)
        {
            return new FeaturedProject
            {
                Name = name,
                Descriptions = descriptions ?? new List<string>(),
                Link = link,
                Technologies = technologies ?? new List<string>(),
                ImageUrl = imageUrl,
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string name, List<string> descriptions, string link, List<string> technologies, string imageUrl)
        {
            Name = name;
            Descriptions = descriptions ?? new List<string>();
            Link = link;
            Technologies = technologies ?? new List<string>();
            ImageUrl = imageUrl;
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string Name { get; set; }
        public List<string> Descriptions { get; set; }
        public string Link { get; set; }
        public List<string> Technologies { get; set; }
        public string ImageUrl { get; set; }
    }
}
