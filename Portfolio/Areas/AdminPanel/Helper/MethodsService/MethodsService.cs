using Portfolio.DbContext;
using Portfolio.Models;

namespace Portfolio.Areas.AdminPanel.Helper.MethodsService
{
    public class MethodsService
    {

        private readonly ClassDbContext _classDbContext;

        public MethodsService(ClassDbContext classDbContext)
        {
            _classDbContext = classDbContext;
        }

        public NameSurnameEntity GetNameSurnameById(int id)
        {
            return _classDbContext.NameSurname.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateNameSurname(NameSurnameEntity newname)
        {
            NameSurnameEntity old = _classDbContext.NameSurname.FirstOrDefault(x => x.Id == newname.Id);
            if (old != null)
            {
                old.Surname = newname.Surname;
                old.Name = newname.Name;
                _classDbContext.SaveChanges();
            }
        }

        public AboutMeEntity GetAboutMeById(int id)
        {
            return _classDbContext.AboutMe.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateAboutMe(AboutMeEntity newabout)
        {
            AboutMeEntity old = _classDbContext.AboutMe.FirstOrDefault(x => x.Id == newabout.Id);
            if (old != null)
            {
                old.Text = newabout.Text;
                _classDbContext.SaveChanges();
            }
        }

        public ProfileImage GetProfileImageById(int id)
        {
            return _classDbContext.profileImages.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateProfileImage(ProfileImage newimage)
        {
            ProfileImage old = _classDbContext.profileImages.FirstOrDefault(x => x.Id == newimage.Id);
            if (old != null)
            {
                old.UrlImage = newimage.UrlImage;
                _classDbContext.SaveChanges();
            }
        }

        public LgProsent GetLgProsentById(int id)
        {
            return _classDbContext.lgProsents.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateLgProsent(LgProsent newlg)
        {
            LgProsent old = _classDbContext.lgProsents.FirstOrDefault(x => x.Id == newlg.Id);
            if (old != null)
            {
                old.Language1 = newlg.Language1;
                old.Language2 = newlg.Language2;
                old.Language3 = newlg.Language3;
                old.Prosent1 = newlg.Prosent1;
                old.Prosent2 = newlg.Prosent2;
                old.Prosent3 = newlg.Prosent3;
                _classDbContext.SaveChanges();
            }
        }

        public AboutMeTextEntity GetAboutText(int id)
        {
            return _classDbContext.AboutMeText.FirstOrDefault(x => x.Id == id);

        }

        public void UpdateAboutText(AboutMeTextEntity newabout)
        {

            AboutMeTextEntity old = _classDbContext.AboutMeText.FirstOrDefault(x => x.Id == newabout.Id);
            old.Text = newabout.Text;
            _classDbContext.SaveChanges();

        }

        public YHP GetYhp(int id)
        {
            return _classDbContext.yHPs.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateYhp(YHP newyhp)
        {

            YHP old = _classDbContext.yHPs.FirstOrDefault(x => x.Id == newyhp.Id);
            old.Project = newyhp.Project;
            old.Years = newyhp.Years;
            old.Hours = newyhp.Hours;
            _classDbContext.SaveChanges();
        }

        public PortfolioProject GetPortfolioProject(int id)
        {
            return _classDbContext.portfolioProjects.FirstOrDefault(x => x.Id == id);
        }

        public void UpdatePortfolioProject(PortfolioProject newportfolioproject)
        {

            PortfolioProject old = _classDbContext.portfolioProjects.FirstOrDefault(x => x.Id == newportfolioproject.Id);
            old.Href = newportfolioproject.Href;
            old.ImageUrl = newportfolioproject.ImageUrl;
            old.ImageText = newportfolioproject.ImageText;
             _classDbContext.SaveChanges();
        }
        
    }
}
