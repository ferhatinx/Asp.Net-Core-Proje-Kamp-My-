using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactUSERNAME { get; set; }
        public string ContactMAIL { get; set; }

        public string ContactSUBJECT { get; set; }

        public string ContactMESSAGE { get; set; }
        public DateTime ContactDATE { get; set; }
        public bool ContactStatus { get; set; }
    }
}
