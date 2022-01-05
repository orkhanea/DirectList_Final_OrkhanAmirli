using DirectList_Final.Data;
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
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View(_context.Messages.OrderByDescending(m=>m.CreatedDate).ToList());
        }

        public IActionResult Read(int? Id)
        {
            if (Id!=null)
            {
                if (_context.Messages.Find(Id)!=null)
                {
                    return View(_context.Messages.Find(Id));
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

           
            
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.Messages.Find(Id) != null)
                {
                    _context.Messages.Remove(_context.Messages.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
    }
}
