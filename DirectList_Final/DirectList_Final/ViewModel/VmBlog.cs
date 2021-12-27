using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmBlog :VmLayout
    {
        public List<Blog> Blog { get; set; }
        public Blog SingleBlog1 { get; set; }
        public Banner Banner { get; set; }

        public CommentPost CommentPost { get; set; }
    }
}
