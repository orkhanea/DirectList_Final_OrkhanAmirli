using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmHome :VmLayout
    {
        public List<Plan> Plan { get; set; }
        public List<Blog> Blog { get; set; }
        public List<Restourant> Restourant { get; set; }
    }
}
