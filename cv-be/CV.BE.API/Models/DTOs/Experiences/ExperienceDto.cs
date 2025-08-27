namespace CV.BE.API.Models.DTOs.Experiences
{
    public class ExperienceDto
    {
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime WorkStartTime { get; set; }
        public DateTime WorkEndTime { get; set; }
        public string Level { get; set; }
        public List<string> Descriptions { get; set; }
    }
}


