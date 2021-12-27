using DirectList_Final.Data;
using DirectList_Final.Models;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new();
            model.Setting = _context.Settings.FirstOrDefault();
            model.ContactUs = _context.ContactUs.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Contact");
            model.SiteSocial = _context.SiteSocials.ToList();
           

            return View(model);
        }

        public IActionResult Message(Message Message)
        {
            if (ModelState.IsValid)
            {
                Message.CreatedDate = DateTime.Now;
                _context.Messages.Add(Message);
                _context.SaveChanges();
            }
           

            return RedirectToAction("Index");
        }
    }
}
