namespace CV.BE.API.Models.DTOs.Educations
{
    public class EducationDto
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public DateTime StudyStartTime { get; set; }
        public DateTime StudyEndTime { get; set; }
        public string Degree { get; set; }
        public List<string> Descriptions { get; set; }
    }
}


