using CV.BE.API.Domains;

namespace CV.BE.UnitTest.Domain
{
    [TestClass]
    public class ContactDomainTests
    {
        [TestMethod]
        public void Create_SetsFields_AndCreatedDate()
        {
            var nowBefore = DateTime.UtcNow.AddSeconds(-1);
            var contact = Contact.Create("a@b.com", "+1", "li", "gh");
            Assert.AreEqual("a@b.com", contact.Email);
            Assert.AreEqual("+1", contact.Phone);
            Assert.AreEqual("li", contact.LinkedIn);
            Assert.AreEqual("gh", contact.GitHub);
            Assert.IsTrue(contact.CreatedDate >= nowBefore);
            Assert.IsFalse(contact.IsDeleted);
        }

        [TestMethod]
        public void Update_ChangesFields_AndUpdatedDate()
        {
            var contact = Contact.Create("a@b.com", "+1", "li", "gh");
            contact.Update("c@d.com", "+2", "li2", "gh2");
            Assert.AreEqual("c@d.com", contact.Email);
            Assert.AreEqual("+2", contact.Phone);
            Assert.AreEqual("li2", contact.LinkedIn);
            Assert.AreEqual("gh2", contact.GitHub);
            Assert.IsNotNull(contact.UpdatedDate);
        }

        [TestMethod]
        public void SoftDelete_SetsFlags_AndIsIdempotent()
        {
            var contact = Contact.Create("a@b.com", "+1", "li", "gh");
            contact.SoftDelete();
            var firstDeleted = contact.DeletedDate;
            contact.SoftDelete();
            Assert.IsTrue(contact.IsDeleted);
            Assert.IsNotNull(firstDeleted);
            Assert.AreEqual(firstDeleted, contact.DeletedDate);
        }
    }
}


