using bakimonarim.business.Abstracts;
using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bakimonarim.webui.Controllers
{
    public class HesapController : Controller
    {
        private readonly IFileService _fileService;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser user;

        public HesapController(UserManager<ApplicationUser> userManager,IFileService fileService)
        {
            _userManager = userManager;
            _fileService = fileService;
        }

        public async Task<IActionResult> Index()
        {
            user = await GetApplicationUser();
            return View(user);
        }
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            user = await GetApplicationUser();
            await _fileService.Add(file, user);
            return RedirectToAction("Index");
        }
        [NonAction]
        private async  Task<ApplicationUser> GetApplicationUser()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
