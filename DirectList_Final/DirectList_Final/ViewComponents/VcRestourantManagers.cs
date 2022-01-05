using DirectList_Final.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewComponents
{
    public class VcRestourantManagers : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcRestourantManagers(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Restourants.OrderByDescending(r=>r.Id).Take(4).ToList());
        }
    }
}
