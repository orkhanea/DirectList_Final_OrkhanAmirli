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
    [Authorize]
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Menu.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _context.Menu.Add(menu);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menu);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Menu.Find(Id) != null)
                {
                    return View(_context.Menu.Find(Id));
                }
                else
                {
                    TempData["MenuError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["MenuError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Update(Menu menu2)
        {
            if (ModelState.IsValid)
            {
                _context.Menu.Update(menu2);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menu2);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.Menu.Find(Id) != null)
                {
                    _context.Menu.Remove(_context.Menu.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["MenuError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["MenuError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
