using CV.BE.Web.Domains;

namespace CV.BE.UnitTest.Domain
{
    [TestClass]
    public class EntityDomainTests
    {
        [TestMethod]
        public void Education_Create_Update_Delete_Works()
        {
            var e = Education.Create("School", "City", new DateTime(2020,1,1), new DateTime(2024,1,1), "BSc", new List<string>{"desc"});
            Assert.AreEqual("School", e.SchoolName);
            e.Update("School2", "City2", e.StudyStartTime, e.StudyEndTime, "MSc", new List<string>{"desc2"});
            Assert.AreEqual("School2", e.SchoolName);
            Assert.AreEqual("MSc", e.Degree);
            Assert.IsNotNull(e.UpdatedDate);
            e.SoftDelete();
            Assert.IsTrue(e.IsDeleted);
        }

        [TestMethod]
        public void Experience_Create_Update_Delete_Works()
        {
            var x = Experience.Create("Company", "City", DateTime.UtcNow, DateTime.UtcNow, "Senior", new List<string>());
            x.Update("Company2", "City2", x.WorkStartTime, x.WorkEndTime, "Lead", new List<string>{"d"});
            Assert.AreEqual("Company2", x.CompanyName);
            x.SoftDelete();
            Assert.IsTrue(x.IsDeleted);
        }

        [TestMethod]
        public void FeaturedProject_Create_Update_Delete_Works()
        {
            var p = FeaturedProject.Create("Proj", new List<string>{"d"}, "link", new List<string>{"c#"}, "img");
            p.Update("Proj2", new List<string>(), "link2", new List<string>(), "img2");
            Assert.AreEqual("Proj2", p.Name);
            p.SoftDelete();
            Assert.IsTrue(p.IsDeleted);
        }

        [TestMethod]
        public void Personal_Create_Update_Delete_Works()
        {
            var p = Personal.Create("A", "B", "Title", "About");
            p.Update("C", "D", "Title2", "About2");
            Assert.AreEqual("C", p.FirstName);
            p.SoftDelete();
            Assert.IsTrue(p.IsDeleted);
        }

        [TestMethod]
        public void Skill_Create_Update_Delete_Works()
        {
            var catId = Guid.NewGuid();
            var s = Skill.Create("Name", 50, catId);
            s.Update("Name2", 75, catId);
            Assert.AreEqual("Name2", s.Name);
            s.SoftDelete();
            Assert.IsTrue(s.IsDeleted);
        }

        [TestMethod]
        public void Testimonial_Create_Update_Delete_Works()
        {
            var t = Testimonial.Create("Author", new List<string>{"d"}, "Pos");
            t.Update("Author2", new List<string>(), "Pos2");
            Assert.AreEqual("Author2", t.AuthorName);
            t.SoftDelete();
            Assert.IsTrue(t.IsDeleted);
        }
    }
}


