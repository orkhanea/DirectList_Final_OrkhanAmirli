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
    public class ProcessController : Controller
    {
        private readonly AppDbContext _context;

        public ProcessController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Processes.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Process model)
        {
            if (ModelState.IsValid)
            {
                _context.Processes.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Processes.Find(Id) != null)
                {
                    return View(_context.Processes.Find(Id));
                }
                else
                {
                    TempData["ProcessError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProcessError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(Process model)
        {
            if (ModelState.IsValid)
            {
                _context.Processes.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.Processes.Find(Id) != null)
                {
                    _context.Processes.Remove(_context.Processes.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ProcessError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProcessError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
