using CV.BE.API.Models.DTOs.Skills;
using CV.BE.API.Services;
using Moq;
using CV.BE.API.Domains;
using CV.BE.API.Repositories;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class SkillServiceTests
    {
        [TestMethod]
        public async Task CreateSkill_Success()
        {
            var repo = new Mock<ISkillRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<Skill>())).ReturnsAsync(Guid.NewGuid());
            var svc = new SkillService(repo.Object);
            var dto = new SkillDto { Name = "N", ProficiencyPercent = 80, SkillCategoryId = Guid.NewGuid() };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }

        [TestMethod]
        public async Task CreateSkillCategory_Success()
        {
            var repo = new Mock<ISkillCategoryRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<SkillCategory>())).ReturnsAsync(Guid.NewGuid());
            var svc = new SkillCategoryService(repo.Object);
            var dto = new SkillCategoryDto { Name = "Backend" };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }
    }
}


