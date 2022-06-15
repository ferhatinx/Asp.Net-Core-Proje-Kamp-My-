using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        readonly CategoryManager cm = new(new EFCategoryRepository());
        
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
         
    }
}
