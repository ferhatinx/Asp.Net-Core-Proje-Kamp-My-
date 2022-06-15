using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager (new EFCategoryRepository());
        public IActionResult Index()
        {
            return View(cm.GetList());
        }
    }
}
