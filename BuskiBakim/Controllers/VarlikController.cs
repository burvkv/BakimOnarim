using bakimonarim.business.Abstracts;
using bakimonarim.entity;
using Microsoft.AspNetCore.Mvc;

namespace BuskiBakim.Controllers
{
    public class VarlikController : Controller
    {
        private readonly IVarlikService _varlikService;

        public VarlikController(IVarlikService varlikService)
        {
            _varlikService = varlikService;
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
