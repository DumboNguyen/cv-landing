namespace CV.BE.Domains
{
    public class Personal : BaseDomain
    {
        public Personal()
        {
            
        }

        public static Personal Create(string firstName, string lastName, string title, string aboutMe)
        {
            return new Personal
            {
                FirstName = firstName,
                LastName = lastName,
                Title = title,
                AboutMe = aboutMe,
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string firstName, string lastName, string title, string aboutMe)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            AboutMe = aboutMe;
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string AboutMe { get; set; }
    }
}
