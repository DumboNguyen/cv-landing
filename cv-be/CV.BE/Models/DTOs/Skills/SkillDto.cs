namespace CV.BE.Models.DTOs.Skills
{
    public class SkillDto
    {
        public string Name { get; set; }
        public int ProficiencyPercent { get; set; }
        public Guid SkillCategoryId { get; set; }
    }
}


