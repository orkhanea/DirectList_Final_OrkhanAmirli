using DirectList_Final.Data;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAdminHome model = new();
            model.Blogs = _context.Blogs.OrderByDescending(b=>b.CreatedDate).Take(3).ToList();
            model.Restourants = _context.Restourants.Include(r=>r.RestourantTagToRestourants).ThenInclude(rt=>rt.RestourantTag).OrderByDescending(r=>r.Id).Take(4).ToList();
            return View(model);
        }
    }
}
