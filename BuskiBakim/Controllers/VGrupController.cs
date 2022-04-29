using bakimonarim.business.Abstracts;
using bakimonarim.entity;
using Microsoft.AspNetCore.Mvc;

namespace BuskiBakim.Controllers
{
    public class VGrupController : Controller
    {
        private readonly IVGrupService _vGrupService;

        public VGrupController(IVGrupService vGrupService)
        {
            _vGrupService = vGrupService;
        }

        [HttpPost]
        public IActionResult Ekle(VGrup vGrup)
        {
            _vGrupService.Add(vGrup);
            return View();
        }
    }
}
