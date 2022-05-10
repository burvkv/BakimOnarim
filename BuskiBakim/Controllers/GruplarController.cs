using bakimonarim.business.Abstracts;
using bakimonarim.entity;

using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BuskiBakim.Controllers
{
    public class GruplarController : Controller
    {
        private readonly IVGrupService _vGrupService;

        public GruplarController(IVGrupService vGrupService)
        {
            _vGrupService = vGrupService;
        }

        
        public IActionResult Index()
        {
           
            
            return View();
        }
        [HttpPost]
        public IActionResult Insert(string values)
        {
            var newGrup = new VGrup();
            JsonConvert.PopulateObject(values, newGrup);
            var result = _vGrupService.Add(newGrup);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update(int key, string values)
        {
            var newGrup = _vGrupService.GetAll().Data.Where(v=>v.GrupID == key).FirstOrDefault();
            JsonConvert.PopulateObject(values, newGrup);
            var result = _vGrupService.Update(newGrup);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(int key)
        {
            var newGrup = _vGrupService.GetAll().Data.Where(v => v.GrupID == key).FirstOrDefault();
            var result = _vGrupService.Delete(newGrup);
            return Ok(result);
        }
        [HttpGet]
        public object GetGroups(DataSourceLoadOptions loadOptions)
        {
            var result = _vGrupService.GetAll();
            return DataSourceLoader.Load(result.Data, loadOptions);
        }

       
    }
}
