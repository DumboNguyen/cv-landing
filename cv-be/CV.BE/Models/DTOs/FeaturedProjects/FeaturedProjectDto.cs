namespace CV.BE.Models.DTOs.FeaturedProjects
{
    public class FeaturedProjectDto
    {
        public string Name { get; set; }
        public List<string> Descriptions { get; set; }
        public string Link { get; set; }
        public List<string> Technologies { get; set; }
        public string ImageUrl { get; set; }
    }
}


