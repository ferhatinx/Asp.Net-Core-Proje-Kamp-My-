using Microsoft.AspNetCore.Mvc;
using NetCore5MuratYucedag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.ViewComponents
{
    public class CommentList : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {

                new UserComment()
                {
                    ID=1,
                    Username="ferhat"
                },
                new UserComment()
                {
                    ID=2,
                    Username="osman"
                },
                new UserComment()
                {
                    ID=3,
                    Username="ilker"
                }
            };
            return View();
        }

    }
}
