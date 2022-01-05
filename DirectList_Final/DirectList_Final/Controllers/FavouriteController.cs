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
    public class FavouriteController : Controller
    {
        private readonly AppDbContext _context;

        public FavouriteController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string oldData = Request.Cookies["favourites"];

            if (!string.IsNullOrEmpty(oldData))
            {
                var favourite = oldData.Split("-").ToList();

               
                    List<Restourant> _restourants = new();
                    foreach (var f in favourite)
                    {
                        _restourants.Add(_context.Restourants.Find(Int32.Parse(f)));
                    }

                    VmFavourite model = new();
                    model.restourants = _restourants;
                    model.Setting = _context.Settings.FirstOrDefault();
                    model.SiteSocial = _context.SiteSocials.ToList();

                    return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
