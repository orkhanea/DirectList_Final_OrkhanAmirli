using DirectList_Final.Data;
using DirectList_Final.Models;
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
    public class MenuToRestourantController : Controller
    {
        private readonly AppDbContext _context;

        public MenuToRestourantController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmMenu model = new();
            model.Menus = _context.Menu.ToList();
            model.MenuToRestourants = _context.MenuToRestourants.ToList();
            model.Restourants = _context.Restourants.Include(r=>r.MenuToRestourants).ThenInclude(mr=>mr.Menu).ToList();

            return View(model);
        }

        public IActionResult Create(int? Id)
        {
            if (Id != null)
            {
                if (_context.Restourants.Find(Id) != null)
                {
                    VmMenu model2 = new();
                    model2.Menus = _context.Menu.ToList();
                    model2.MenuToRestourants = _context.MenuToRestourants.ToList();
                    model2.Restourants2 = _context.Restourants.Include(r => r.MenuToRestourants).ThenInclude(mr => mr.Menu).FirstOrDefault(r => r.Id == Id);

                    return View(model2);
                }
                else
                {

                    TempData["RMenuError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["RMenuError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Create(VmMenu model3)
        {
            if (ModelState.IsValid)
            {
                if (_context.Menu.Find(model3.MenuNameId)!=null)
                {

                    if (model3.MenuPrice > 0)
                    {
                        MenuToRestourant menuToRestourant = new();
                        menuToRestourant.MenuId = model3.MenuNameId;
                        menuToRestourant.Ingrediend = model3.MenuIngrediend;
                        menuToRestourant.Price = model3.MenuPrice;
                        menuToRestourant.RestourantId = model3.RestourantId;

                        _context.MenuToRestourants.Add(menuToRestourant);
                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["RMenuError2"] = "Price must be greater than 0";
                        model3.Menus = _context.Menu.ToList();
                        model3.MenuToRestourants = _context.MenuToRestourants.ToList();
                        model3.Restourants2 = _context.Restourants.Include(r => r.MenuToRestourants).ThenInclude(mr => mr.Menu).FirstOrDefault(r => r.Id == model3.RestourantId);
                        return View(model3);
                    }


                    
                }
                else
                {
                    TempData["RMenuError2"] = "Such an id does not exist";
                    model3.Menus = _context.Menu.ToList();
                    model3.MenuToRestourants = _context.MenuToRestourants.ToList();
                    model3.Restourants2 = _context.Restourants.Include(r => r.MenuToRestourants).ThenInclude(mr => mr.Menu).FirstOrDefault(r => r.Id == model3.RestourantId);
                    return View(model3);
                }



            }
            else
            {
                model3.Menus = _context.Menu.ToList();
                model3.MenuToRestourants = _context.MenuToRestourants.ToList();
                model3.Restourants2 = _context.Restourants.Include(r => r.MenuToRestourants).ThenInclude(mr => mr.Menu).FirstOrDefault(r => r.Id == model3.RestourantId);
                return View(model3);
            }

            
           
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.MenuToRestourants.Find(Id) != null)
                {
                    ViewBag.MenuB = _context.Menu.ToList();
                    return View(_context.MenuToRestourants.Include(m => m.Restourant).Include(m => m.Menu).FirstOrDefault(m => m.Id == Id));
                }
                else
                {
                    TempData["RMenuError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["RMenuError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(MenuToRestourant model5)
        {
            if (ModelState.IsValid)
            {
                _context.MenuToRestourants.Update(model5);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MenuB = _context.Menu.ToList();
            return View(_context.MenuToRestourants.Include(m => m.Restourant).Include(m => m.Menu).FirstOrDefault(m => m.Id == model5.Id));

        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.MenuToRestourants.Find(Id) != null)
                {
                    _context.MenuToRestourants.Remove(_context.MenuToRestourants.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["RMenuError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["RMenuError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

    }
}
