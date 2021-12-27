using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmAbout : VmLayout
    {
        public AboutUs AboutUs { get; set; }
        public List<Process> Process { get; set; }
        public Banner Banner { get; set; }
    }
}
