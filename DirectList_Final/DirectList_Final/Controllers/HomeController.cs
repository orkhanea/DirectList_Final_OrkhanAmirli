using DirectList_Final.Data;
using DirectList_Final.Models;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmHome model = new();
            model.Setting = _context.Settings.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.Plan = _context.Plans.ToList();
            model.Restourant = _context.Restourants.ToList();
            model.Blog = _context.Blogs.Take(3).OrderByDescending(b => b.CreatedDate).ToList();

            ViewBag.RestourantTags = _context.RestourantTags.ToList();

            return View(model);
        }

        
    }
}
