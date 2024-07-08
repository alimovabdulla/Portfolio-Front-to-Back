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
                profileImage = _dbContext.profileImages.ToList()
               

            };



        }
    }
}