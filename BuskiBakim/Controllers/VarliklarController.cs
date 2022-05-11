using bakimonarim.business.Abstracts;
using bakimonarim.entity;

using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BuskiBakim.Controllers
{
    [Authorize]
    public class VarliklarController : Controller
    {
        private readonly IVarlikService _varlikService;

        public VarliklarController(IVarlikService varlikService)
        {
            _varlikService = varlikService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Varlıklar";
            return View();
        }

        [HttpPost]
        public IActionResult Insert(string values)
        {
            var newVarlik = new Varlik2();
            JsonConvert.PopulateObject(values, newVarlik);
            var result = _varlikService.Add(newVarlik);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update(int key, string values)
        {
            var newVarlik = _varlikService.GetAll().Data.Where(v=>v.VarlikID == key).FirstOrDefault();
            JsonConvert.PopulateObject(values, newVarlik);
            var result = _varlikService.Update(newVarlik);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(int key)
        {
            var newVarlik = _varlikService.GetAll().Data.Where(v => v.VarlikID == key).FirstOrDefault();
            var result = _varlikService.Delete(newVarlik);
            return Ok(result);
        }
        [HttpGet]
        public object VarliklariGetir(DataSourceLoadOptions loadOptions)
        {
            var result = _varlikService.GetAll();
            return DataSourceLoader.Load(result.Data, loadOptions);
        }
       
       
    }
}
