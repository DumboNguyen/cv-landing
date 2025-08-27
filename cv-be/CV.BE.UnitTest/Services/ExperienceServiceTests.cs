using CV.BE.Web.Models.DTOs.Experiences;
using CV.BE.Web.Services;
using CV.BE.Web.Domains;
using CV.BE.Web.Repositories;
using Moq;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class ExperienceServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_Success()
        {
            var repo = new Mock<IExperienceRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<Experience>())).ReturnsAsync(Guid.NewGuid());
            var svc = new ExperienceService(repo.Object);
            var dto = new ExperienceDto { CompanyName = "C", Location = "L", WorkStartTime = DateTime.UtcNow, WorkEndTime = DateTime.UtcNow, Level = "Lvl", Descriptions = new List<string>() };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }
    }
}


