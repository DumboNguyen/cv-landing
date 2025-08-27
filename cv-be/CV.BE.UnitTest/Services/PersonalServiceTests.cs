using CV.BE.Models.DTOs.Personals;
using CV.BE.Repositories;
using CV.BE.Services;
using Moq;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class PersonalServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_ReturnsId_OnSuccess()
        {
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<CV.BE.Domains.Personal>())).ReturnsAsync(Guid.NewGuid());
            var svc = new PersonalService(repo.Object);

            var dto = new PersonalDto { FirstName = "A", LastName = "B", Title = "T", AboutMe = "About" };
            var result = await svc.CreateAsync(dto);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreNotEqual(Guid.Empty, result is CV.BE.Models.Responses.ServiceResult<Guid> g ? g.Data : Guid.Empty);
            repo.Verify(r => r.AddAsync(It.IsAny<CV.BE.Domains.Personal>()), Times.Once);
        }

        [TestMethod]
        public async Task UpdateAsync_Fails_WhenNotFound()
        {
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync((CV.BE.Domains.Personal)null);
            var svc = new PersonalService(repo.Object);

            var result = await svc.UpdateAsync(Guid.NewGuid(), new PersonalDto());

            Assert.IsFalse(result.IsSuccess);
        }

        [TestMethod]
        public async Task DeleteAsync_SoftDeletes_WhenFound()
        {
            var entity = CV.BE.Domains.Personal.Create("A","B","T","About");
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            repo.Setup(r => r.UpdateAsync(It.IsAny<CV.BE.Domains.Personal>())).ReturnsAsync(true);
            var svc = new PersonalService(repo.Object);

            var result = await svc.DeleteAsync(Guid.NewGuid());

            Assert.IsTrue(result.IsSuccess);
            Assert.IsTrue(entity.IsDeleted);
        }
    }
}


