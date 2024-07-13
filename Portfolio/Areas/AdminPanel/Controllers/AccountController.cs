using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.DbContext;
using Portfolio.DTOs.LoginDTO;
using Portfolio.DTOs.RegisterDTO;
using Portfolio.Models.User;

namespace Portfolio.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class AccountController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ClassDbContext _classDbContext;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ClassDbContext classDbContext)
        {
            _classDbContext = classDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            AppUser appUser = new AppUser();
            appUser.UserName = registerDTO.Email;

            var results = await _userManager.CreateAsync(appUser, registerDTO.Password);
            await _classDbContext.SaveChangesAsync();
            if (!results.Succeeded)
            {
                string error = "";
                foreach (var item in results.Errors)
                {
                    error += item;
                }
                ModelState.AddModelError(string.Empty, error);
            }
            else if (results.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            await _classDbContext.SaveChangesAsync();

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            AppUser user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                ModelState.TryAddModelError("", "Bele Bir Istifadeci Yoxdur");
                return View();

            }
            var results = await _signInManager.PasswordSignInAsync(user, password, true, false);
            if (results.Succeeded)
            {
                return RedirectToAction("Edit","Dashboard");
            }
            else
            {
                ModelState.AddModelError("", "Sifre yalnisdir");
                return View();
            }

        }
 
    }
}
