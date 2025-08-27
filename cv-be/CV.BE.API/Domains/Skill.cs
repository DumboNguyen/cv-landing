namespace CV.BE.API.Domains
{
    public class Skill : BaseDomain
    {
        public Skill()
        {

        }

        public static Skill Create(string name, int proficiencyPercent, Guid skillCategoryId)
        {
            return new Skill
            {
                Name = name,
                ProficiencyPercent = proficiencyPercent,
                SkillCategoryId = skillCategoryId,
                CreatedDate = DateTime.UtcNow
            };
        }

        public void Update(string name, int proficiencyPercent, Guid skillCategoryId)
        {
            Name = name;
            ProficiencyPercent = proficiencyPercent;
            SkillCategoryId = skillCategoryId;
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
        }

        public string Name { get; set; }
        public int ProficiencyPercent { get; set; }
        public Guid SkillCategoryId { get; set; }

        public SkillCategory SkillCategory { get; set; }
    }
}
