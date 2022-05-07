using Microsoft.AspNetCore.Mvc;
using bakimonarim.business.Abstracts;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using BuskiBakim.ViewModels;

namespace bakimonarim.webui.Controllers
{
    public class MalzemeController : Controller
    {
        IMalzemeService _malzemeService;
        public MalzemeController(IMalzemeService malzemeService)
        {
      
            _malzemeService = malzemeService;
        }

        [HttpGet]
        public object OlmayanMalzemeleriGetir(DataSourceLoadOptions loadOptions){
            var result = _malzemeService.GetAll().Data.Where(m=>m.Adet==0 && m.Adet!=null);
            return DataSourceLoader.Load(result, loadOptions);
        }

        
    }
}
