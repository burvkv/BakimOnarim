using Microsoft.AspNetCore.Mvc;
using bakimonarim.business.Abstracts;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace bakimonarim.webui.Controllers
{
    [Authorize]
    public class MalzemeController : Controller
    {
        IMalzemeService _malzemeService;
        public MalzemeController(IMalzemeService malzemeService)
        {
            ViewData["Title"] = "Malzemeler";
            _malzemeService = malzemeService;
        }

        [HttpGet]
        public object OlmayanMalzemeleriGetir(DataSourceLoadOptions loadOptions){
            var result = _malzemeService.GetAll().Data.Where(m=>m.Adet==0 && m.Adet!=null);
            return DataSourceLoader.Load(result, loadOptions);
        }

        
    }
}
