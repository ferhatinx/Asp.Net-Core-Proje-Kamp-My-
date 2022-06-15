using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterNAME { get; set; }

        public string WriterIMAGE { get; set; }
        public string WriterABOUT { get; set; }

        public string WriterMAIL { get; set; }

        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
