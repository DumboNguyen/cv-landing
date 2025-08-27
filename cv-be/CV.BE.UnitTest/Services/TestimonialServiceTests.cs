using CV.BE.API.Models.DTOs.Testimonials;
using CV.BE.API.Services;
using Moq;
using CV.BE.API.Domains;
using CV.BE.API.Repositories;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class TestimonialServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_Success()
        {
            var repo = new Mock<ITestimonialRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<Testimonial>())).ReturnsAsync(Guid.NewGuid());
            var svc = new TestimonialService(repo.Object);
            var dto = new TestimonialDto { AuthorName = "A", Descriptions = new List<string>(), AuthorPosition = "P" };
            var res = await svc.CreateAsync(dto);
            Assert.IsTrue(res.IsSuccess);
        }
    }
}


