
namespace CV.BE.Domains
{
    public class SkillCategory : BaseDomain
    {
        public SkillCategory()
        {
            Skills = new List<Skill>();
        }

        public string Name { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
