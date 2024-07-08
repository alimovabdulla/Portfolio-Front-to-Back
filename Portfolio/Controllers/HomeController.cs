using Microsoft.AspNetCore.Mvc;
using Portfolio.DbContext;
using Portfolio.Helper.DbService;
using Portfolio.Models;
using Portfolio.ViewModels;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioDbService _dbService;
        private readonly ILogger<HomeController> _logger;
        private readonly ClassDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, ClassDbContext classDbContext, PortfolioDbService portfolioDbService)
        {
            _dbService = portfolioDbService;
            _dbContext = classDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            PortfolioViewModel model = _dbService.GetPortfolioViewModel();


            return View(model);
        }


    }
}
