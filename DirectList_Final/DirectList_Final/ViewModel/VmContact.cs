using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmContact : VmLayout
    {
        public Message Message { get; set; }
        public ContactUs ContactUs { get; set; }
        public Banner Banner { get; set; }
    }
}
