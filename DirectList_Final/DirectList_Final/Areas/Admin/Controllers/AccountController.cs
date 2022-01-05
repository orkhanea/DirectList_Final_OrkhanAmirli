using DirectList_Final.Data;
using DirectList_Final.Models;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _webHostEnviroment = webHostEnviroment;
        }

        [Authorize(Roles = "Super Admin")]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize(Roles = "Super Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                CustomUser newUser = new()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.UserName,
                    Email = model.Email,
                    CreatedDate = DateTime.Now

                };

                var result = await _userManager.CreateAsync(newUser, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View(model);
                }
            }

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(VmLogin model)
        {
            if (ModelState.IsValid)
            {
                
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect Username or Password");
                    return View(model);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

        [Authorize(Roles= "Super Admin")]
        public IActionResult Users()
        {
            VmUsers model = new();
            model.CustomUsers = _context.CustomUsers.ToList();
            model.IdentityRoles = _context.Roles.ToList();
            model.UserRoles = _context.UserRoles.ToList();
            return View(model);
        }

        [Authorize(Roles = "Super Admin")]
        public IActionResult UserUpdate(string Id)
        {
            if (Id!=null)
            {
                if (_context.CustomUsers.Find(Id)!=null)
                {
                    CustomUser model2 = _context.CustomUsers.Find(Id);
                    model2.RoleId = _context.UserRoles.Where(u=>u.UserId==Id).Select(r=>r.RoleId).FirstOrDefault();

                    ViewBag.Roles = _context.Roles.ToList();
                    return View(model2);
                }
                else
                {
                    TempData["UserError"] = "Such an Id does not exist";
                    return RedirectToAction("Users");
                }
            }
            else
            {
                TempData["UserError"] = "Id must not be null";
                return RedirectToAction("Users");
            }

        }

        [Authorize(Roles = "Super Admin")]
        [HttpPost]
        public async Task<IActionResult> UserUpdate(CustomUser model)
        {
            if (ModelState.IsValid)
            {
                CustomUser customUser = _context.CustomUsers.Find(model.Id);
                customUser.Name = model.Name;
                customUser.Surname = model.Surname;
                customUser.UserName = model.UserName;
                customUser.Email = model.Email;
                customUser.PhoneNumber = model.PhoneNumber;

                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            customUser.Image = ImageName;

                        }
                        else
                        {
                            TempData["UserError2"] = "The size of the Image file must be less than 3 MB";
                            ViewBag.Roles = _context.Roles.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["UserError2"] = "The type of Image file can only be jpeg/jpg or png";
                        ViewBag.Roles = _context.Roles.ToList();
                        return View(model);
                    }

                }


                IdentityUserRole<string> userRole = _context.UserRoles.FirstOrDefault(u => u.UserId == model.Id);

                if (userRole !=null)
                {
                    string oldRole = _context.Roles.Find(userRole.RoleId).Name;
                    await _userManager.RemoveFromRoleAsync(customUser, oldRole);
                }
                _context.SaveChanges();

                IdentityRole identityRole = _context.Roles.Find(model.RoleId);
                if (identityRole!=null)
                {
                    await _userManager.AddToRoleAsync(customUser, identityRole.Name);
                }
                

                _context.SaveChanges();
                return RedirectToAction("Users");
            }

            ViewBag.Roles = _context.Roles.ToList();
            return View(model);
        }

        [Authorize(Roles = "Super Admin")]
        public IActionResult Roles()
        {
            List<IdentityRole> roles = _context.Roles.ToList();

            return View(roles);
        }

        [Authorize(Roles = "Super Admin")]
        public IActionResult RoleCreate()
        {
            return View();
        }

        [Authorize(Roles = "Super Admin")]
        [HttpPost]
        public async Task<IActionResult> RoleCreate(IdentityRole model)
        {
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(model);
                return RedirectToAction("Roles");
            }

            ModelState.AddModelError("", "Upps..");
            return View(model);
        }

        
    }
}
