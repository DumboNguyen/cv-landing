using CV.BE.Web.Models.DTOs.Testimonials;
using CV.BE.Web.Services;
using CV.BE.Web.Domains;
using CV.BE.Web.Repositories;
using Moq;

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


