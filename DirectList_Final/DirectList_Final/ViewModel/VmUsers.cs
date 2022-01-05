using DirectList_Final.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmUsers
    {
        public List<CustomUser> CustomUsers { get; set; }
        public List<IdentityRole> IdentityRoles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
