using DirectList_Final.Data;
using DirectList_Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class RestourantController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public RestourantController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }

        public IActionResult Index()
        {
            return View(_context.Restourants.Include(r=>r.RestourantTagToRestourants).ThenInclude(rt=>rt.RestourantTag).ToList());
        }

        public IActionResult Detail(int? Id)
        {
            if (Id != null)
            {
                if (_context.Restourants.Find(Id)!=null)
                {
                    Restourant restourant = _context.Restourants.Include(mr => mr.MenuToRestourants)
                                                       .ThenInclude(m => m.Menu)
                                                       .Include(r => r.RestourantTagToRestourants).ThenInclude(rt => rt.RestourantTag)
                                                       .Include(rf => rf.RestourantFeatureToRestourants).ThenInclude(f => f.RestourantFeature)
                                                       .Include(rc => rc.RestourantComments).ThenInclude(cp => cp.CommentPost)
                                                       .Include(r => r.Reservations).ThenInclude(g => g.Guest).FirstOrDefault(r => r.Id == Id);
                    return View(restourant);
                }
                else
                {
                    TempData["RestourantError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["RestourantError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }

        public IActionResult Create()
        {
            ViewBag.Menus = _context.Menu.ToList();
            ViewBag.Features = _context.RestourantFeatures.ToList();
            ViewBag.Tags = _context.RestourantTags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restourant restourant)
        {
            if (ModelState.IsValid)
            {
                if (restourant.LogoFile != null)
                {
                    if (restourant.LogoFile.ContentType == "image/jpeg" || restourant.LogoFile.ContentType == "image/png")
                    {
                        if (restourant.LogoFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + restourant.LogoFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                restourant.LogoFile.CopyTo(Stream);
                            }

                            restourant.Logo = ImageName2;

                            if (restourant.ManagerImageFile != null)
                            {
                                if (restourant.ManagerImageFile.ContentType == "image/jpeg" || restourant.ManagerImageFile.ContentType == "image/png")
                                {
                                    if (restourant.ManagerImageFile.Length < 3000000)
                                    {
                                        string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + restourant.ManagerImageFile.FileName;
                                        string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                                        using (var Stream = new FileStream(FilePath, FileMode.Create))
                                        {
                                            restourant.ManagerImageFile.CopyTo(Stream);
                                        }


                                        restourant.ManagerImage = ImageName;
                                        _context.Restourants.Add(restourant);
                                        _context.SaveChanges();

                                        if (restourant.RestourantTagToRestourantId != null && restourant.RestourantTagToRestourantId.Count > 0)
                                        {

                                            foreach (var item in restourant.RestourantTagToRestourantId)
                                            {
                                                RestourantTagToRestourant restourantTagToRestourant = new();
                                                restourantTagToRestourant.RestourantTagId = item;
                                                restourantTagToRestourant.RestourantId = restourant.Id;
                                                _context.RestourantTagToRestourants.Add(restourantTagToRestourant);

                                            }
                                            _context.SaveChanges();

                                        }
                                        if (restourant.RestourantFeatureToRestourantId != null && restourant.RestourantFeatureToRestourantId.Count > 0)
                                        {

                                            foreach (var item in restourant.RestourantFeatureToRestourantId)
                                            {
                                                RestourantFeatureToRestourant restourantfeatureToRestourant = new();
                                                restourantfeatureToRestourant.RestourantFeatureId = item;
                                                restourantfeatureToRestourant.RestourantId = restourant.Id;
                                                _context.RestourantFeatureToRestourants.Add(restourantfeatureToRestourant);

                                            }
                                            _context.SaveChanges();

                                        }
                                        _context.SaveChanges();
                                        return RedirectToAction("Index");
                                    }
                                    else
                                    {
                                        ViewBag.Menus = _context.Menu.ToList();
                                        ViewBag.Features = _context.RestourantFeatures.ToList();
                                        ViewBag.Tags = _context.RestourantTags.ToList();
                                        TempData["RestourantError2"] = "The size of the Image file must be less than 3 MB";
                                        return View(restourant);
                                    }
                                }
                                else
                                {
                                    ViewBag.Menus = _context.Menu.ToList();
                                    ViewBag.Features = _context.RestourantFeatures.ToList();
                                    ViewBag.Tags = _context.RestourantTags.ToList();
                                    TempData["RestourantError2"] = "The type of Image file can only be jpeg/jpg or png";
                                    return View(restourant);
                                }
                            }
                            else
                            {
                                ViewBag.Menus = _context.Menu.ToList();
                                ViewBag.Features = _context.RestourantFeatures.ToList();
                                ViewBag.Tags = _context.RestourantTags.ToList();
                                TempData["RestourantError2"] = "Image field must not be empty. Please choose a image";
                                return View(restourant);
                            }

                        }
                        else
                        {
                            ViewBag.Menus = _context.Menu.ToList();
                            ViewBag.Features = _context.RestourantFeatures.ToList();
                            ViewBag.Tags = _context.RestourantTags.ToList();
                            TempData["RestourantError2"] = "The size of the Image file must be less than 3 MB";
                            return View(restourant);
                        }
                    }
                    else
                    {
                        ViewBag.Menus = _context.Menu.ToList();
                        ViewBag.Features = _context.RestourantFeatures.ToList();
                        ViewBag.Tags = _context.RestourantTags.ToList();
                        TempData["RestourantError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(restourant);
                    }
                }
                else
                {
                    ViewBag.Menus = _context.Menu.ToList();
                    ViewBag.Features = _context.RestourantFeatures.ToList();
                    ViewBag.Tags = _context.RestourantTags.ToList();
                    TempData["RestourantError2"] = "Image field must not be empty. Please choose a image";
                    return View(restourant);
                }
            }
            else
            {
                ViewBag.Menus = _context.Menu.ToList();
                ViewBag.Features = _context.RestourantFeatures.ToList();
                ViewBag.Tags = _context.RestourantTags.ToList();
                return View(restourant);
            }

            
        }

        public IActionResult Update(int? Id)
        {
            if (Id!=null)
            {
                if (_context.Restourants.Find(Id)!=null)
                {
                    ViewBag.Menus = _context.Menu.ToList();
                    ViewBag.Features = _context.RestourantFeatures.ToList();
                    ViewBag.Tags = _context.RestourantTags.ToList();
                    Restourant model = _context.Restourants.Include(t => t.RestourantTagToRestourants).ThenInclude(tr => tr.RestourantTag)
                                                           .Include(f=>f.RestourantFeatureToRestourants).ThenInclude(fr=>fr.RestourantFeature)
                                                           .FirstOrDefault(r=>r.Id==Id);
                    model.RestourantFeatureToRestourantId = _context.RestourantFeatureToRestourants.Where(rf =>rf.RestourantId == Id).Select(tb => tb.RestourantFeatureId).ToList();
                    model.RestourantTagToRestourantId = _context.RestourantTagToRestourants.Where(tr =>tr.RestourantId == Id).Select(tb => tb.RestourantTagId).ToList();
                    return View(model);
                }
                else
                {
                    TempData["RestourantError4"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["RestourantError4"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(Restourant model)
        {
            if (ModelState.IsValid)
            {

                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.Logo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.LogoFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(Stream);
                            }

                            model.Logo = ImageName;
                        }
                        else
                        {
                            ViewBag.Menus = _context.Menu.ToList();
                            ViewBag.Features = _context.RestourantFeatures.ToList();
                            ViewBag.Tags = _context.RestourantTags.ToList();
                            TempData["RestourantError3"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        ViewBag.Menus = _context.Menu.ToList();
                        ViewBag.Features = _context.RestourantFeatures.ToList();
                        ViewBag.Tags = _context.RestourantTags.ToList();
                        TempData["RestourantError3"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.ManagerImageFile != null)
                {
                    if (model.ManagerImageFile.ContentType == "image/jpeg" || model.ManagerImageFile.ContentType == "image/png")
                    {
                        if (model.ManagerImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.ManagerImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.ManagerImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ManagerImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ManagerImageFile.CopyTo(Stream);
                            }

                            model.ManagerImage = ImageName;
                        }
                        else
                        {
                            ViewBag.Menus = _context.Menu.ToList();
                            ViewBag.Features = _context.RestourantFeatures.ToList();
                            ViewBag.Tags = _context.RestourantTags.ToList();
                            TempData["RestourantError3"] = "The size of the Home Page Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        ViewBag.Menus = _context.Menu.ToList();
                        ViewBag.Features = _context.RestourantFeatures.ToList();
                        ViewBag.Tags = _context.RestourantTags.ToList();
                        TempData["RestourantError3"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }

                _context.SaveChanges();


                //Delete old RestourantFeatureToRestourant
                List<RestourantFeatureToRestourant> restourantFeatureToRestourants = _context.RestourantFeatureToRestourants.Where(t => t.RestourantId == model.Id).ToList();
                foreach (var item in restourantFeatureToRestourants)
                {
                    _context.RestourantFeatureToRestourants.Remove(item);
                    _context.SaveChanges();
                }

                //Create new RestourantFeatureToRestourant
                if (model.RestourantFeatureToRestourantId != null && model.RestourantFeatureToRestourantId.Count > 0)
                {

                    foreach (var item in model.RestourantFeatureToRestourantId)
                    {
                        RestourantFeatureToRestourant restourantFeatureToRestourant2 = new();
                        restourantFeatureToRestourant2.RestourantFeatureId = item;
                        restourantFeatureToRestourant2.RestourantId = model.Id;
                        _context.RestourantFeatureToRestourants.Add(restourantFeatureToRestourant2);
                        _context.SaveChanges();
                    }


                }

                //Delete old RestourantTagToRestourant
                List<RestourantTagToRestourant> restourantTagToRestourants = _context.RestourantTagToRestourants.Where(t => t.RestourantId == model.Id).ToList();
                foreach (var item in restourantTagToRestourants)
                {
                    _context.RestourantTagToRestourants.Remove(item);
                    _context.SaveChanges();
                }

                //Create new RestourantTagToRestourant
                if (model.RestourantTagToRestourantId != null && model.RestourantTagToRestourantId.Count > 0)
                {

                    foreach (var item in model.RestourantTagToRestourantId)
                    {
                        RestourantTagToRestourant restourantTagToRestourant2 = new();
                        restourantTagToRestourant2.RestourantTagId = item;
                        restourantTagToRestourant2.RestourantId = model.Id;
                        _context.RestourantTagToRestourants.Add(restourantTagToRestourant2);
                        _context.SaveChanges();
                    }


                }

                _context.Restourants.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");



            }

            ViewBag.Menus = _context.Menu.ToList();
            ViewBag.Features = _context.RestourantFeatures.ToList();
            ViewBag.Tags = _context.RestourantTags.ToList();
            return View(model);
        }

        [Authorize(Roles = "Super Admin")]
        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Restourant model = _context.Restourants.Find(Id);

                if (model!= null)
                {
                    if (!string.IsNullOrEmpty(model.Logo))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.Logo);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    if (!string.IsNullOrEmpty(model.ManagerImage))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.ManagerImage);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    List<RestourantComment> restourantComments = _context.RestourantComments.Include(c => c.CommentPost).Where(c => c.RestourantId == Id).ToList();
                    List<CommentPost> commentPosts = restourantComments.Select(c => c.CommentPost).ToList();

                    foreach (var cp in commentPosts)
                    {
                        _context.CommentPosts.Remove(cp);
                    }

                    foreach (var c in restourantComments)
                    {
                        _context.RestourantComments.Remove(c);
                    }
                    _context.SaveChanges();


                    Restourant restourant = _context.Restourants.Include(mr => mr.MenuToRestourants)
                                                        .ThenInclude(m => m.Menu)
                                                        .Include(r => r.RestourantTagToRestourants).ThenInclude(rt => rt.RestourantTag)
                                                        .Include(rf => rf.RestourantFeatureToRestourants).ThenInclude(f => f.RestourantFeature)
                                                        .Include(rc => rc.RestourantComments).ThenInclude(cp => cp.CommentPost)
                                                        .Include(r => r.Reservations).ThenInclude(g => g.Guest).FirstOrDefault(r => r.Id == Id);


                    _context.Restourants.Remove(restourant);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["RestourantError4"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["RestourantError4"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }

        public IActionResult DeleteCom(int? Id)
        {
            if (Id != null)
            {
                if (_context.RestourantComments.Find(Id) != null)
                {
                    RestourantComment restourantComment = _context.RestourantComments.Include(c => c.CommentPost).FirstOrDefault(c => c.Id == Id);
                    CommentPost commentPost = restourantComment.CommentPost;
                    _context.CommentPosts.Remove(commentPost);
                    

                    _context.RestourantComments.Remove(restourantComment);
                    _context.SaveChanges();
                    return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
                }
                else
                {
                    TempData["CommentError2"] = "Such an id does not exist";
                    return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
                }
            }
            else
            {
                TempData["CommentError2"] = "Id must not be null";
                return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
            }
        }

        public IActionResult DeleteRes(int? Id)
        {
            if (Id != null)
            {
                if (_context.Reservations.Find(Id) != null)
                {

                    _context.Reservations.Remove(_context.Reservations.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
                }
                else
                {
                    TempData["CommentError2"] = "Such an id does not exist";
                    return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
                }
            }
            else
            {
                TempData["CommentError2"] = "Id must not be null";
                return RedirectToAction("Detail", new { Id = (int)TempData["RestourantId"] });
            }
        }
    }


}
