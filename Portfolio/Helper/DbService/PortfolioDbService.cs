using Portfolio.DbContext;
using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Helper.DbService
{
    public class PortfolioDbService
    {

        private readonly ClassDbContext _dbContext;
        public PortfolioDbService(ClassDbContext classDb)
        {
            _dbContext = classDb;
        }

        public PortfolioViewModel GetPortfolioViewModel()
        {
            return new PortfolioViewModel
            {
                lgProsents = _dbContext.lgProsents.ToList(),
                nameSurname = _dbContext.NameSurname.ToList(),
                AboutMe = _dbContext.AboutMe.ToList(),
                AboutMeText = _dbContext.AboutMeText.ToList(),
                yhp = _dbContext.yHPs.ToList(),
                profileImage = _dbContext.profileImages.ToList(),
                portfolioProject = _dbContext.portfolioProjects.ToList(),
                latestWorks = _dbContext.latestWorksText.ToList(),
                txts = _dbContext.txts.ToList(),
                blog = _dbContext.blog.ToList(),
                blogtxtEntities = _dbContext.blogtxtEntities.ToList(),
                servicesEntity = _dbContext.servicesEntity.ToList(),
                myClientsLogos = _dbContext.myClientsLogos.ToList(),
                connectEntities = _dbContext.connectEntities.ToList(),
                connectTexts = _dbContext.connectTexts.ToList(),
                educations = _dbContext.educations.ToList(),
                experiences = _dbContext.experiences.ToList(),
                resumeTxtEntities = _dbContext.resumeTxtEntities.ToList(),
                testimonial = _dbContext.testimonial.ToList(),
               
                 

            };



        }
    }
}