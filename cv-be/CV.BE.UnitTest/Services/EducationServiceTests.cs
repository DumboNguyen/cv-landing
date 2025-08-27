using CV.BE.Web.Models.DTOs.Educations;
using CV.BE.Web.Services;
using CV.BE.Web.Domains;
using CV.BE.Web.Repositories;
using Moq;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class EducationServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_Success()
        {
            var repo = new Mock<IEducationRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<Education>())).ReturnsAsync(Guid.NewGuid());
            var svc = new EducationService(repo.Object);
            var dto = new EducationDto { SchoolName = "S", Location = "L", StudyStartTime = DateTime.UtcNow, StudyEndTime = DateTime.UtcNow, Degree = "D", Descriptions = new List<string>() };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }

        [TestMethod]
        public async Task UpdateAsync_NotFound()
        {
            var repo = new Mock<IEducationRepository>();
            repo.Setup(r => r.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync((Education)null);
            var svc = new EducationService(repo.Object);
            var res = await svc.UpdateAsync(Guid.NewGuid(), new EducationDto());
            Assert.IsFalse(res.IsSuccess);
        }
    }
}


