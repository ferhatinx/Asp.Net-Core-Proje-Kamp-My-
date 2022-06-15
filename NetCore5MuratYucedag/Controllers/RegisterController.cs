using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetCore5MuratYucedag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.Controllers
{
   
    public class RegisterController : Controller
    {
        readonly WriterManager wm = new WriterManager(new EFWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            CityList citys = new CityList();
            ViewBag.i = citys;
            return View(citys);
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidation wv = new WriterValidation();
            ValidationResult results = wv.Validate(writer);
            if (results.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterABOUT = "DENEME TEST";
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else 
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            
            }
            return View();
          
        }
    }
}
