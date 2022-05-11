using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using bakimonarim.webui.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace bakimonarim.webui.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signinManager;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;
        }
        public async Task<IActionResult> Logout()
        {
            
            await _signinManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

       [HttpGet]
        public IActionResult Login()
        {
            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signinManager.PasswordSignInAsync(p.Username, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Panel");
                }

            }
            else
            {
                RedirectToAction("Login", "Auth");
            }
            return View();

        }
 
        [HttpGet]
        public IActionResult Register()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = p.Mail,
                    UserName = p.Username                
                };
                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
