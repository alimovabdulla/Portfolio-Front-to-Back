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
        public IActionResult DeletePortfolio(int id)
        {
            PortfolioProject portfolioProject = _classDbContext.portfolioProjects.FirstOrDefault(p => p.Id == id);
            _classDbContext.Remove(portfolioProject);
            _classDbContext.SaveChanges();
            return RedirectToAction("Edit");
        }


    }

}