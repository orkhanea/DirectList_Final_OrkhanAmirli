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
    public class RestourantFeatureC : Controller
    {
        private readonly AppDbContext _context;

        public RestourantFeatureC (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.RestourantFeatures.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestourantFeature model)
        {
            if (ModelState.IsValid)
            {
                _context.RestourantFeatures.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.RestourantFeatures.Find(Id) != null)
                {
                    return View(_context.RestourantFeatures.Find(Id));
                }
                else
                {
                    TempData["FeatureError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FeatureError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(RestourantFeature model)
        {
            if (ModelState.IsValid)
            {
                _context.RestourantFeatures.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.RestourantFeatures.Find(Id) != null)
                {
                    _context.RestourantFeatures.Remove(_context.RestourantFeatures.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["FeatureError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FeatureError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
