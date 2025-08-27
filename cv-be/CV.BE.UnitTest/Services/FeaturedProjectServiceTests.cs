using CV.BE.API.Models.DTOs.FeaturedProjects;
using CV.BE.API.Services;
using Moq;
using CV.BE.API.Domains;
using CV.BE.API.Repositories;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class FeaturedProjectServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_Success()
        {
            var repo = new Mock<IFeaturedProjectRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<FeaturedProject>())).ReturnsAsync(Guid.NewGuid());
            var svc = new FeaturedProjectService(repo.Object);
            var dto = new FeaturedProjectDto { Name = "P", Descriptions = new List<string>(), Link = "l", Technologies = new List<string>(), ImageUrl = "i" };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }
    }
}


