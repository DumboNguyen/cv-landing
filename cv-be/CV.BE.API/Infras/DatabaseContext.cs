using CV.BE.API.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CV.BE.API.Infras
{
    public interface IDatabaseContext
    {
        DbSet<Contact> Contacts { get; set; }
        DbSet<Personal> Personals { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Experience> Experiences { get; set; }
        DbSet<SkillCategory> SkillCategories { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<FeaturedProject> FeaturedProjects { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public string ConnectionString { get; set; }

        public DatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString, delegate (SqlServerDbContextOptionsBuilder opt)
            {
                opt.EnableRetryOnFailure();
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Personal>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Education>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Experience>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<SkillCategory>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Skill>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<FeaturedProject>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Testimonial>().HasQueryFilter(c => !c.IsDeleted);

            //// store list of strings as JSON in NVARCHAR(MAX)
            //var stringListConverter = new ValueConverter<List<string>, string>(
            //    v => JsonConvert.SerializeObject(v ?? new List<string>()),
            //    v => string.IsNullOrWhiteSpace(v) ? new List<string>() : JsonConvert.DeserializeObject<List<string>>(v)
            //);

            //modelBuilder.Entity<Education>()
            //    .Property(e => e.Descriptions)
            //    .HasConversion(stringListConverter);

            //modelBuilder.Entity<Experience>()
            //    .Property(e => e.Descriptions)
            //    .HasConversion(stringListConverter);

            //modelBuilder.Entity<FeaturedProject>()
            //    .Property(e => e.Descriptions)
            //    .HasConversion(stringListConverter);

            //modelBuilder.Entity<FeaturedProject>()
            //    .Property(e => e.Technologies)
            //    .HasConversion(stringListConverter);

            //modelBuilder.Entity<Testimonial>()
            //    .Property(e => e.Descriptions)
            //    .HasConversion(stringListConverter);
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<FeaturedProject> FeaturedProjects { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
