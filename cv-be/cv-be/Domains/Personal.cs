namespace CV.BE.Domains
{
    public class Personal : BaseDomain
    {
        public Personal()
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string AboutMe { get; set; }
    }
}
