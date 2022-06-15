using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5MuratYucedag.Models
{
    public class CityList
    {
        public int City { get; set; }

        public List<SelectListItem> Cities { get; set; }
    }

}
