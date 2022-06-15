using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        readonly CommentManager cm = new(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values); 
        }
        }
}
