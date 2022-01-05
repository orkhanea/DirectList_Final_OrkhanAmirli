using DirectList_Final.Data;
using DirectList_Final.Models;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Controllers
{
    public class RestourantController : Controller
    {
        private readonly AppDbContext _context;

        public RestourantController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index(string SearchData, int? SearchTagData)
        {
            VmRestourant model = new();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Restourants");
            model.SiteSocial = _context.SiteSocials.ToList();
            model.Restourants = _context.Restourants
                                .Include(r => r.RestourantTagToRestourants)
                                .ThenInclude(rt => rt.RestourantTag)
                                .Where(r => (SearchData!=null?r.Name.Contains(SearchData):true) &&
                                            (SearchTagData!=null?r.RestourantTagToRestourants.Any(rt=>rt.RestourantTagId==SearchTagData):true)).ToList();
            
            ViewBag.RestourantTags = _context.RestourantTags.ToList();

            string oldData = Request.Cookies["favourites"];

            if (!string.IsNullOrEmpty(oldData))
            {
                model.favourite = oldData.Split("-").ToList();
            }

            if (model.Restourants.Count == 0)
            {
                TempData["SearchError"] = "Your search did not match any of them";
            }
           
            return View(model);
        }

        public IActionResult SingleRestourant(int? Id)
        {
            if (Id!=null)
            {
                VmRestourant model2 = new();
                if (model2!=null)
                {
                    model2.Setting = _context.Settings.FirstOrDefault();
                    model2.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Restourant");
                    model2.SiteSocial = _context.SiteSocials.ToList();
                    model2.SingleRestourant = _context.Restourants.Include(mr => mr.MenuToRestourants)
                                                             .ThenInclude(m => m.Menu)
                                                             .Include(r => r.RestourantTagToRestourants).ThenInclude(rt => rt.RestourantTag)
                                                             .Include(rf => rf.RestourantFeatureToRestourants).ThenInclude(f => f.RestourantFeature)
                                                             .Include(rc => rc.RestourantComments).ThenInclude(cp => cp.CommentPost)
                                                             .Include(r => r.Reservations).ThenInclude(g => g.Guest).FirstOrDefault(r => r.Id == Id);
                    ViewBag.Guests = _context.Guests.ToList();

                    return View(model2);
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult PostComment(CommentPost commentPost)
        {
            if (ModelState.IsValid)
            {
                _context.CommentPosts.Add(commentPost);
                

                RestourantComment restourantComment = new();
                restourantComment.RestourantId = commentPost.RestourantdId;
                restourantComment.CreatedDate = DateTime.Now;
                restourantComment.Content = commentPost.Content;
                _context.SaveChanges();
                restourantComment.CommentPostId = commentPost.Id;

                _context.RestourantComments.Add(restourantComment);
                _context.SaveChanges();


            }

            return RedirectToAction("SingleRestourant", new { Id = commentPost.RestourantdId });
        }

        public IActionResult Reservation(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                reservation.CreatedDate = DateTime.Now;
                _context.Reservations.Add(reservation);
                _context.SaveChanges();

                TempData["ReservSuccess"] = "Your reservation has been confirmed";
                return RedirectToAction("SingleRestourant", new { Id = reservation.RestourantId });
            }

            TempData["ReservError"] = "Please fill the blanks correctly";
            return RedirectToAction("SingleRestourant", new { Id = reservation.RestourantId });
        }

        public IActionResult AddToFavourites(int Id)
        {
            string oldData = Request.Cookies["favourites"];
            string newData = null;

            if (string.IsNullOrEmpty(oldData))
            {
                newData = Id.ToString();
            }
            else
            {
                List<string> favouriteList = oldData.Split("-").ToList();
                if (favouriteList.Any(f => f == Id.ToString()))
                {
                    favouriteList.Remove(Id.ToString());
                    newData = string.Join("-", favouriteList);
                }
                else
                {
                    newData = oldData + "-" + Id;
                }
            }

            CookieOptions options = new()
            {
                Expires = DateTime.Now.AddMonths(1)
            };

            Response.Cookies.Append("favourites", newData, options);

            return RedirectToAction("Index");
        }
    }
}
