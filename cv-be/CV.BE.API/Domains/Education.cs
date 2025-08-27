namespace CV.BE.API.Domains
{
    public class Education : BaseDomain
    {
        public Education()
        {
            Descriptions = new List<string>();
        }

        public static Education Create(string schoolName, string location, DateTime studyStartTime, DateTime studyEndTime, string degree, List<string> descriptions)
        {
            return new Education
            {
                SchoolName = schoolName,
                Location = location,
                StudyStartTime = studyStartTime,
                StudyEndTime = studyEndTime,
                Degree = degree,
                Descriptions = descriptions ?? new List<string>(),
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string schoolName, string location, DateTime studyStartTime, DateTime studyEndTime, string degree, List<string> descriptions)
        {
            SchoolName = schoolName;
            Location = location;
            StudyStartTime = studyStartTime;
            StudyEndTime = studyEndTime;
            Degree = degree;
            Descriptions = descriptions ?? new List<string>();
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string SchoolName { get; set; }
        public string Location { get; set; }
        public DateTime StudyStartTime { get; set; }
        public DateTime StudyEndTime { get; set; }
        public string Degree { get; set; }
        public List<string> Descriptions { get; set; }
    }
}
