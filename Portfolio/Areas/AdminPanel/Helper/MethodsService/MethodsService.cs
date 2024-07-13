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
        // Methods for NameSurnameEntity
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
        // Methods for NameSurnameEntity
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
        // Methods for ProfileImage
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
        // Methods for LgProsent
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
        // Methods for AboutMeTextEntity
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
        // Methods for YHP
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
        // Methods for PortfolioProject
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
        // Methods for LatestsEntity
        public LatestsEntity GetLatestText(int id)
        {
            return _classDbContext.latestWorksText.FirstOrDefault(x => x.Id == x.Id);
        }

        public void UpdateLatests(LatestsEntity newtextEntity)
        {
            LatestsEntity old = _classDbContext.latestWorksText.FirstOrDefault(x => x.Id == newtextEntity.Id);
            old.Text = newtextEntity.Text;

            _classDbContext.SaveChanges();
        }

        // Methods for BlogEntity
        public BlogEntity GetBlog(int id)
        {
            return _classDbContext.blog.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBlog(BlogEntity newBlogEntity)
        {
            BlogEntity old = _classDbContext.blog.FirstOrDefault(x => x.Id == newBlogEntity.Id);
            if (old != null)
            {
                old.Description = newBlogEntity.Description;
                old.Data = newBlogEntity.Data;
                old.ImageUrl = newBlogEntity.ImageUrl;
                old.Name = newBlogEntity.Name;
                old.Href = newBlogEntity.Href;
                _classDbContext.SaveChanges();
            }
        }

        // Methods for BlogtxtEntity
        public BlogtxtEntity GetBlogtxt(int id)
        {
            return _classDbContext.blogtxtEntities.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBlogtxt(BlogtxtEntity newBlogtxtEntity)
        {
            BlogtxtEntity old = _classDbContext.blogtxtEntities.FirstOrDefault(x => x.Id == newBlogtxtEntity.Id);
            if (old != null)
            {
                old.Text = newBlogtxtEntity.Text;
                _classDbContext.SaveChanges();
            }
        }

        // Methods for TestimonialEntity
        public TestimonialEntity GetTestimonial(int id)
        {
            return _classDbContext.testimonial.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTestimonial(TestimonialEntity newTestimonialEntity)
        {
            TestimonialEntity old = _classDbContext.testimonial.FirstOrDefault(x => x.Id == newTestimonialEntity.Id);
            if (old != null)
            {
                old.Text = newTestimonialEntity.Text;
                old.Name = newTestimonialEntity.Name;
                old.PPurl = newTestimonialEntity.PPurl;
                old.Profession = newTestimonialEntity.Profession;

                _classDbContext.SaveChanges();
            }
        }

        // Methods for ServicesEntity
        public ServicesEntity GetServicesEntity(int id)
        {
            return _classDbContext.servicesEntity.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateServicesEntity(ServicesEntity newServicesEntity)
        {
            ServicesEntity old = _classDbContext.servicesEntity.FirstOrDefault(x => x.Id == newServicesEntity.Id);
            if (old != null)
            {
                old.Text = newServicesEntity.Text;
                old.Number = newServicesEntity.Number;
                old.Profession = newServicesEntity.Profession;
                old.LogoUrl = newServicesEntity.LogoUrl;

                _classDbContext.SaveChanges();
            }
        }

        // Methods for ResumeTxtEntity
        public ResumeTxtEntity GetResumeTxt(int id)
        {
            return _classDbContext.resumeTxtEntities.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateResumeTxt(ResumeTxtEntity newResumeTxtEntity)
        {
            ResumeTxtEntity old = _classDbContext.resumeTxtEntities.FirstOrDefault(x => x.Id == newResumeTxtEntity.Id);
            if (old != null)
            {
                old.Text = newResumeTxtEntity.Text;

                _classDbContext.SaveChanges();
            }
        }

        // Methods for MyClientsLogosEntity
        public MyClientsLogosEntity GetMyClientsLogos(int id)
        {
            return _classDbContext.myClientsLogos.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateMyClientsLogos(MyClientsLogosEntity newMyClientsLogosEntity)
        {
            MyClientsLogosEntity old = _classDbContext.myClientsLogos.FirstOrDefault(x => x.Id == newMyClientsLogosEntity.Id);

            old.ImageUrlLogo = newMyClientsLogosEntity.ImageUrlLogo;
            old.Href = newMyClientsLogosEntity.Href;


            _classDbContext.SaveChanges();

        }

        // Methods for Experience
        public Experience GetExperience(int id)
        {
            return _classDbContext.experiences.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateExperience(Experience newExperience)
        {
            Experience old = _classDbContext.experiences.FirstOrDefault(x => x.Id == newExperience.Id);
            if (old != null)
            {
                old.Position = newExperience.Position;
                old.Years = newExperience.Years;
                old.Company = newExperience.Company;
                _classDbContext.SaveChanges();
            }
        }

        // Methods for EducationEntity
        public EducationEntity GetEducation(int id)
        {
            return _classDbContext.educations.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateEducation(EducationEntity newEducationEntity)
        {
            EducationEntity old = _classDbContext.educations.FirstOrDefault(x => x.Id == newEducationEntity.Id);
            if (old != null)
            {
                old.Years = newEducationEntity.Years;
                old.University = newEducationEntity.University;

                old.Degree = newEducationEntity.Degree;
                _classDbContext.SaveChanges();
            }
        }

        // Methods for ConnectText
        public ConnectText GetConnectText(int id)
        {
            return _classDbContext.connectTexts.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateConnectText(ConnectText newConnectText)
        {
            ConnectText old = _classDbContext.connectTexts.FirstOrDefault(x => x.Id == newConnectText.Id);
            if (old != null)
            {
                old.Text = newConnectText.Text;
                _classDbContext.SaveChanges();
            }
        }

        // Methods for ConnectEntity
        public ConnectEntity GetConnectEntity(int id)
        {
            return _classDbContext.connectEntities.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateConnectEntity(ConnectEntity newConnectEntity)
        {
            ConnectEntity old = _classDbContext.connectEntities.FirstOrDefault(x => x.Id == newConnectEntity.Id);
            if (old != null)
            {
                old.Address = newConnectEntity.Address;
                old.Number = newConnectEntity.Number;
                old.Email = newConnectEntity.Email;

                _classDbContext.SaveChanges();
            }
        }
        // Methods for ServicesTxt
        public ServicesTxt GetServicesTxt(int id)
        {
            return _classDbContext.txts.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateServiceTxt(ServicesTxt newServicesTxt)
        {
            ServicesTxt old = _classDbContext.txts.FirstOrDefault(x => x.Id == newServicesTxt.Id);
            old.ServiceText = newServicesTxt.ServiceText;
            _classDbContext.SaveChanges();
        }
        public ToggleEntity GetToggles(int id)
        {
            return _classDbContext.toggleEntities.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateToggle(ToggleEntity newToggle)
        {
            ToggleEntity old = _classDbContext.toggleEntities.FirstOrDefault(x => x.Id == newToggle.Id);
            old.Number = newToggle.Number;
            old.WhatsApp = newToggle.WhatsApp;
            old.Instagram = newToggle.Instagram;
            old.Email = newToggle.Email;
            old.Telegram = newToggle.Telegram;
            _classDbContext.SaveChanges();

        }


        public HeaderSocialLinks GetHeaderSocialLinks(int id)
        {
            return _classDbContext.HeaderSocialLinks.FirstOrDefault(x=>x.Id==id);

        }
        public void UpdateHeaderSocialLinks(HeaderSocialLinks newHeaderSocialLinks)
        {
            HeaderSocialLinks old = _classDbContext.HeaderSocialLinks.FirstOrDefault(x=>x.Id == newHeaderSocialLinks.Id);
            old.Linkedin = newHeaderSocialLinks.Linkedin;
            old.GitHub = newHeaderSocialLinks.GitHub;
            _classDbContext.SaveChanges();
        }
    }



}
