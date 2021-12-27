using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmRestourant :VmLayout
    {
        public List<Restourant> Restourants { get; set; }
        public Restourant SingleRestourant { get; set; }
        public Banner Banner { get; set; }
        public CommentPost CommentPost { get; set; }
        public Reservation Reservation { get; set; }
        public List<string> favourite { get; set; }
    }
}
