using DirectList_Final.Data;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmAbout model = new();
            model.AboutUs = _context.AboutUs.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "About");
            model.Process = _context.Processes.ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            return View(model);
        }
    }
}
