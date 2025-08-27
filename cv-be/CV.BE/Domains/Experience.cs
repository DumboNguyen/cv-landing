namespace CV.BE.Domains
{
    public class Experience : BaseDomain
    {
        public Experience()
        {
            
        }

        public static Experience Create(string companyName, string location, DateTime workStartTime, DateTime workEndTime, string level, List<string> descriptions)
        {
            return new Experience
            {
                CompanyName = companyName,
                Location = location,
                WorkStartTime = workStartTime,
                WorkEndTime = workEndTime,
                Level = level,
                Descriptions = descriptions ?? new List<string>(),
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string companyName, string location, DateTime workStartTime, DateTime workEndTime, string level, List<string> descriptions)
        {
            CompanyName = companyName;
            Location = location;
            WorkStartTime = workStartTime;
            WorkEndTime = workEndTime;
            Level = level;
            Descriptions = descriptions ?? new List<string>();
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime WorkStartTime { get; set; }
        public DateTime WorkEndTime { get; set; }
        public string Level { get; set; }
        public List<string> Descriptions { get; set; }
    }
}
