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
    public class RestourantTagController : Controller
    {
        private readonly AppDbContext _context;

        public RestourantTagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.RestourantTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestourantTag model)
        {
            if (ModelState.IsValid)
            {
                _context.RestourantTags.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.RestourantTags.Find(Id) != null)
                {
                    return View(_context.RestourantTags.Find(Id));
                }
                else
                {
                    TempData["TagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["TagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(RestourantTag model)
        {
            if (ModelState.IsValid)
            {
                _context.RestourantTags.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.RestourantTags.Find(Id) != null)
                {
                    _context.RestourantTags.Remove(_context.RestourantTags.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["TagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["TagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
