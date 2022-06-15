using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.Controllers
{
    public class BlogController : Controller
    {
        readonly BlogManager bm = new (new EFBlogRepository());
        public IActionResult Index()
        {
            return View(bm.GetBlogListWithCategory());
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
