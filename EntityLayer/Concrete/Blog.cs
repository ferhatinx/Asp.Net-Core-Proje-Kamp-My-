using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTITLE { get; set; }
        public string BlogCONTENT { get; set; }

        public string BlogTHUMBNAILIMAGE { get; set; }

        public string BlogIMAGE { get; set; }
        public DateTime BlogCREATEDATE { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int WriterID { get; set; }
        public Writer Writer { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
