using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.DbContext
{
    public class ClassDbContext : IdentityDbContext
    {
        public ClassDbContext(DbContextOptions<ClassDbContext> options) : base(options)
        {

        }
        public DbSet<LatestsEntity> latestWorksText { get; set; }

        public DbSet<AboutMeEntity> AboutMe { get; set; }
        public DbSet<AboutMeTextEntity> AboutMeText { get; set; }
        public DbSet<NameSurnameEntity> NameSurname { get; set; }
        public DbSet<LgProsent> lgProsents { get; set; }
        public DbSet<YHP> yHPs { get; set; }
        public DbSet<ProfileImage> profileImages { get; set; }
        public DbSet<PortfolioProject> portfolioProjects { get; set; }
        public DbSet <ServicesTxt> txts { get; set; }

        public DbSet<BlogEntity> blog { get; set; }
        public DbSet<BlogtxtEntity> blogtxtEntities { get; set; }
        public DbSet<TestimonialEntity> testimonial { get; set; }

        public DbSet<ServicesEntity> servicesEntity { get; set; }
        public DbSet<ResumeTxtEntity> resumeTxtEntities { get; set; }
        public DbSet<MyClientsLogosEntity> myClientsLogos { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<EducationEntity> educations { get; set; }
        public DbSet<ConnectText> connectTexts { get; set; }
        public DbSet<ConnectEntity> connectEntities { get; set; }
        
    }

}
