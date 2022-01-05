using DirectList_Final.Data;
using DirectList_Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Super Admin")]
    public class SiteSettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public SiteSettingController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {

            return View(_context.Settings.FirstOrDefault()); ;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Setting model)
        {
            if (ModelState.IsValid)
            {
                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length < 3000000)
                        {
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.LogoFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(Stream);
                            }

                            model.Logo = ImageName;

                            if (model.BgImageFile != null)
                            {
                                if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                                {
                                    if (model.BgImageFile.Length < 3000000)
                                    {
                                        string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                                        string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName2);

                                        using (var Stream = new FileStream(FilePath2, FileMode.Create))
                                        {
                                            model.BgImageFile.CopyTo(Stream);
                                        }

                                        model.BgImage = ImageName2;

                                        _context.Settings.Add(model);
                                        _context.SaveChanges();
                                        return RedirectToAction("Index");

                                    }
                                    else
                                    {
                                        TempData["SettingError"] = "The size of the Home Page Image file must be less than 3 MB";
                                        return View(model);
                                    }
                                }
                                else
                                {
                                    TempData["SettingError"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                                    return View(model);
                                }
                            }
                            else
                            {
                                TempData["SettingError"] = "Home Page Image field must not be empty. Please choose a image";
                                return View(model);
                            }

                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["SettingError"] = "Logo Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View();
        }

        public IActionResult Update()
        {


            return View(_context.Settings.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Setting model)
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
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.BgImageFile != null)
                {
                    if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                    {
                        if (model.BgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.BgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Home Page Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }

                _context.Settings.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
