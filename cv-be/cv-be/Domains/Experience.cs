namespace CV.BE.Domains
{
    public class Experience : BaseDomain
    {
        public Experience()
        {
            
        }

        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime WorkStartTime { get; set; }
        public DateTime WorkEndTime { get; set; }
        public string Level { get; set; }
        public List<string> Descriptions { get; set; }
    }
}
