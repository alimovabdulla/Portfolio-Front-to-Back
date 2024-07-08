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
    }
}
