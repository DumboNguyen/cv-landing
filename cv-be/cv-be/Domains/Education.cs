
namespace CV.BE.Domains
{
    public class Education : BaseDomain
    {
        public Education()
        {
            Descriptions = new List<string>();
        }

        public string SchoolName { get; set; }
        public string Location { get; set; }
        public DateTime StudyStartTime { get; set; }
        public DateTime StudyEndTime { get; set; }
        public string Degree { get; set; }
        public List<string> Descriptions { get; set; }
    }
}
