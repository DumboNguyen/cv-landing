using CV.BE.API.Models.DTOs.Personals;
using CV.BE.API.Services;
using Moq;
using CV.BE.API.Models.DTOs;
using CV.BE.API.Domains;
using CV.BE.API.Repositories;

namespace CV.BE.UnitTest.Services
{
    [TestClass]
    public class PersonalServiceTests
    {
        [TestMethod]
        public async Task CreateAsync_ReturnsId_OnSuccess()
        {
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.AddAsync(It.IsAny<Personal>())).ReturnsAsync(Guid.NewGuid());
            var svc = new PersonalService(repo.Object);

            var dto = new PersonalDto { FirstName = "A", LastName = "B", Title = "T", AboutMe = "About" };
            var result = await svc.CreateAsync(dto);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreNotEqual(Guid.Empty, result is ServiceResult<Guid> g ? g.Data : Guid.Empty);
            repo.Verify(r => r.AddAsync(It.IsAny<Personal>()), Times.Once);
        }

        [TestMethod]
        public async Task UpdateAsync_Fails_WhenNotFound()
        {
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync((Personal)null);
            var svc = new PersonalService(repo.Object);

            var result = await svc.UpdateAsync(Guid.NewGuid(), new PersonalDto());

            Assert.IsFalse(result.IsSuccess);
        }

        [TestMethod]
        public async Task DeleteAsync_SoftDeletes_WhenFound()
        {
            var entity = Personal.Create("A","B","T","About");
            var repo = new Mock<IPersonalRepository>();
            repo.Setup(r => r.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            repo.Setup(r => r.UpdateAsync(It.IsAny<Personal>())).ReturnsAsync(true);
            var svc = new PersonalService(repo.Object);

            var result = await svc.DeleteAsync(Guid.NewGuid());

            Assert.IsTrue(result.IsSuccess);
            Assert.IsTrue(entity.IsDeleted);
        }
    }
}


