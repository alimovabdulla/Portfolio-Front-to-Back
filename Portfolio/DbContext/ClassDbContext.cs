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
        public DbSet<LgProsent>  lgProsents { get; set; }
        public DbSet <YHP> yHPs { get; set; }
        public DbSet<ProfileImage> profileImages { get; set; }
        public DbSet<PortfolioProject>  portfolioProjects { get; set; }
    }

}
