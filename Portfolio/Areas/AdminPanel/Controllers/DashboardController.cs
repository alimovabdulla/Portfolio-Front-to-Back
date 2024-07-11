using Microsoft.AspNetCore.Mvc;
using Portfolio.Areas.AdminPanel.Helper.MethodsService;
using Portfolio.DbContext;
using Portfolio.Helper.DbService;
using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        private readonly ClassDbContext _classDbContext;
        private readonly PortfolioDbService _dbService;
        private readonly MethodsService _methodsService;
        public DashboardController(PortfolioDbService dbService, ClassDbContext classDbContext, MethodsService methodsService)
        {
            _methodsService = methodsService;
            _classDbContext = classDbContext;
            _dbService = dbService;
        }


        public IActionResult Edit()
        {
            PortfolioViewModel model = _dbService.GetPortfolioViewModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult EditName(int id)
        {
            NameSurnameEntity exist = _methodsService.GetNameSurnameById(id);
            return View(exist);
        }
        [HttpPost]
        public IActionResult EditName(NameSurnameEntity newname)
        {
            _methodsService.UpdateNameSurname(newname);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            AboutMeEntity exist = _methodsService.GetAboutMeById(id);
            return View(exist);
        }
        [HttpPost]
        public IActionResult EditAbout(AboutMeEntity newabout)
        {
            _methodsService.UpdateAboutMe(newabout);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditPP(int id)
        {
            ProfileImage exist = _methodsService.GetProfileImageById(id);
            return View(exist);
        }
        [HttpPost]
        public IActionResult EditPP(ProfileImage newimage)
        {
            _methodsService.UpdateProfileImage(newimage);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditLanguages(int id)
        {
            LgProsent existing = _methodsService.GetLgProsentById(id);
            return View(existing);
        }
        [HttpPost]
        public IActionResult EditLanguages(LgProsent newlg)
        {
            _methodsService.UpdateLgProsent(newlg);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditAboutTxt(int id)
        {
            AboutMeTextEntity exiting = _methodsService.GetAboutText(id);
            return View(exiting);
        }
        [HttpPost]
        public IActionResult EditAboutTxt(AboutMeTextEntity newabout)
        {

            _methodsService.UpdateAboutText(newabout);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditYhp(int id)
        {
            YHP exiting = _methodsService.GetYhp(id);
            return View(exiting);
        }
        [HttpPost]
        public IActionResult EditYhp(YHP newyhp)
        {
            _methodsService.UpdateYhp(newyhp);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            PortfolioProject exiting = _methodsService.GetPortfolioProject(id);
            return View(exiting);
        }
        [HttpPost]
        public IActionResult EditPortfolio(PortfolioProject newportfolio)
        {
            _methodsService.UpdatePortfolioProject(newportfolio);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(PortfolioProject newportfolioProject)
        {
            _classDbContext.Add(newportfolioProject);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            PortfolioProject portfolioProject = _classDbContext.portfolioProjects.FirstOrDefault(p => p.Id == id);
            _classDbContext.Remove(portfolioProject);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditWorks(int id)
        {
            LatestsEntity exiting = _methodsService.GetLatestText(id);
            return View(exiting);
        }
        [HttpPost]
        public IActionResult EditWorks(LatestsEntity newtextEntity)
        {
            _methodsService.UpdateLatests(newtextEntity);
            return RedirectToAction("Edit");
        }
        public IActionResult EditLatestText(int id)
        {
            LatestsEntity existing = _methodsService.GetLatestText(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditLatestText(LatestsEntity newLatestsEntity)
        {
            _methodsService.UpdateLatests(newLatestsEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditBlog(int id)
        {
            BlogEntity existing = _methodsService.GetBlog(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditBlog(BlogEntity newBlogEntity)
        {
            _methodsService.UpdateBlog(newBlogEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditBlogtxt(int id)
        {
            BlogtxtEntity existing = _methodsService.GetBlogtxt(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditBlogtxt(BlogtxtEntity newBlogtxtEntity)
        {
            _methodsService.UpdateBlogtxt(newBlogtxtEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditTestimonial(int id)
        {
            TestimonialEntity existing = _methodsService.GetTestimonial(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditTestimonial(TestimonialEntity newTestimonialEntity)
        {
            _methodsService.UpdateTestimonial(newTestimonialEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditServicesEntity(int id)
        {
            ServicesEntity existing = _methodsService.GetServicesEntity(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditServicesEntity(ServicesEntity newServicesEntity)
        {
            _methodsService.UpdateServicesEntity(newServicesEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditResumeTxt(int id)
        {
            ResumeTxtEntity existing = _methodsService.GetResumeTxt(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditResumeTxt(ResumeTxtEntity newResumeTxtEntity)
        {
            _methodsService.UpdateResumeTxt(newResumeTxtEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditMyClientsLogos(int id)
        {
            MyClientsLogosEntity existing = _methodsService.GetMyClientsLogos(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditMyClientsLogos(MyClientsLogosEntity newMyClientsLogosEntity)
        {
            _methodsService.UpdateMyClientsLogos(newMyClientsLogosEntity);
            return RedirectToAction("Edit");
        }

        public IActionResult EditExperience(int id)
        {
            Experience existing = _methodsService.GetExperience(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience newExperience)
        {
            _methodsService.UpdateExperience(newExperience);
            return RedirectToAction("Edit");
        }
        public IActionResult EditEducation(int id)
        {
            EducationEntity existing = _methodsService.GetEducation(id);
            return View(existing);
        }
        [HttpPost]
        public IActionResult EditEducation(EducationEntity newEducationEntity)
        {
            _methodsService.UpdateEducation(newEducationEntity);
            return RedirectToAction("Edit");
        }
        public IActionResult EditConnectText(int id)
        {
            ConnectText existing = _methodsService.GetConnectText(id);
            return View(existing);
        }
        [HttpPost]
        public IActionResult EditConnectText(ConnectText newConnectText)
        {
            _methodsService.UpdateConnectText(newConnectText);
            return RedirectToAction("Edit");
        }
        public IActionResult EditConnectEntity(int id)
        {
            ConnectEntity existing = _methodsService.GetConnectEntity(id);
            return View(existing);
        }
        [HttpPost]
        public IActionResult EditConnectEntity(ConnectEntity newConnectEntity)
        {
            _methodsService.UpdateConnectEntity(newConnectEntity);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult EditServiceTxt(int id)
        {
            ServicesTxt exiting = _methodsService.GetServicesTxt(id);
            return View(exiting);
        }
        [HttpPost]
        public IActionResult EditServiceTxt(ServicesTxt newServicesTxt)
        {
            _methodsService.UpdateServiceTxt(newServicesTxt);
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreateServices() { return View(); }
        [HttpPost]
        public IActionResult CreateServices(ServicesEntity newServices)
        {
            _classDbContext.Add(newServices);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");

        }
        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            ServicesEntity servicesEntity = _classDbContext.servicesEntity.FirstOrDefault(s => s.Id == id);
            _classDbContext.Remove(servicesEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(TestimonialEntity newTestimonial)
        {
            _classDbContext.Add(newTestimonial);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            TestimonialEntity testimonialEntity = _classDbContext.testimonial.FirstOrDefault(x => x.Id == x.Id);
            _classDbContext.Remove(testimonialEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(EducationEntity education)
        {
            _classDbContext.Add(education);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {

            _classDbContext.Add(experience);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeleteEducation(int id)
        {
            EducationEntity educationEntity = _classDbContext.educations.FirstOrDefault(x => x.Id == id);
            _classDbContext.Remove(educationEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            Experience experience = _classDbContext.experiences.FirstOrDefault(x => x.Id == id);
            _classDbContext.Remove(experience);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");

        }
        [HttpGet]
        public IActionResult CreateClientsLogo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClientsLogo(MyClientsLogosEntity myClientsLogosEntity)
        {
            _classDbContext.Add(myClientsLogosEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeleteClientLogo(int id)
        {
            MyClientsLogosEntity myClientsLogosEntity = _classDbContext.myClientsLogos.FirstOrDefault(x => x.Id == id);
            _classDbContext.Remove(myClientsLogosEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(BlogEntity blogEntity)
        {
            _classDbContext.Add(blogEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }
        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            BlogEntity blogEntity = _classDbContext.blog.FirstOrDefault(x => x.Id == id);
            _classDbContext.Remove(blogEntity);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");

        }
    }

}