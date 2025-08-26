
namespace CV.BE.Domains
{
    public class Skill : BaseDomain
    {
        public Skill()
        {
            
        }

        public string Name { get; set; }
        public int ProficiencyPercent { get; set; }
        public Guid SkillCategoryId { get; set; }

        public SkillCategory SkillCategory { get; set; }
    }
}
