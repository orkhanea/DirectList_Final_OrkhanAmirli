using DirectList_Final.Data;
using DirectList_Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Super Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.ContactUs.FirstOrDefault());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactUs.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

            
        }

        public IActionResult Update(int? Id)
        {
            if (Id!=null)
            {

                if (_context.ContactUs.Find(Id)!=null)
                {
                    return View(_context.ContactUs.Find(Id));
                }
                else
                {
                    TempData["ContactError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ContactError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactUs.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }


        }

        public IActionResult Delete(int? Id)
        {
            if (Id!=null)
            {
                if (_context.ContactUs.Find(Id)!=null)
                {
                    _context.ContactUs.Remove(_context.ContactUs.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ContactError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ContactError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
