using DirectList_Final.Data;
using DirectList_Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnviroment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.OrderByDescending(b=>b.CreatedDate).ToList());
        }

        public IActionResult Detail(int? Id)
        {
            if (Id != null)
            {
                if (_context.Blogs.Find(Id) != null)
                {
                   Blog model=_context.Blogs.Include(cu => cu.CustomUser)
                                            .Include(c => c.Comments)
                                            .ThenInclude(cp => cp.CommentPost).FirstOrDefault(p => p.Id == Id);
                    return View(model);

                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/jpeg" || blog.ImageFile.ContentType == "image/png")
                    {
                        if (blog.ImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + blog.ImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(Stream);
                            }

                            blog.Image = ImageName2;
                            blog.CreatedDate = DateTime.Now;
                            blog.CustomUserId = _userManager.GetUserId(User);
                            _context.Blogs.Add(blog);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["BlogError3"] = "The size of the Image file must be less than 3 MB";
                            return View(blog);
                        }
                    }
                    else
                    {
                        TempData["BlogError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(blog);
                    }
                }
                else
                {
                    TempData["BlogError3"] = "Image field must not be empty. Please choose a image";
                    return View(blog);
                }
            }

            return View(blog);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Blogs.Find(Id) != null)
                {
                   
                    return View(_context.Blogs.Find(Id));

                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/jpeg" || blog.ImageFile.ContentType == "image/png")
                    {
                        if (blog.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(blog.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", blog.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + blog.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(Stream);
                            }

                            blog.Image = ImageName;

                        }
                        else
                        {
                            TempData["BlogError2"] = "The size of the Image file must be less than 3 MB";
                            return View(blog);
                        }
                    }
                    else
                    {
                        TempData["BlogError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(blog);
                    }

                }


                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(blog);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Blog blog = _context.Blogs.Find(Id);
                if (blog != null)
                {
                    if (!string.IsNullOrEmpty(blog.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", blog.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    List<Comment> comments = _context.Comments.Include(c=>c.CommentPost).Where(c => c.BlogId == Id).ToList();
                    List<CommentPost> commentPosts = comments.Select(c => c.CommentPost).ToList();

                    foreach (var cp in commentPosts)
                    {
                        _context.CommentPosts.Remove(cp);
                    }

                    foreach (var c in comments)
                    {
                        _context.Comments.Remove(c);
                    }

                    _context.Blogs.Remove(blog);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteCom(int? Id)
        {
            if (Id!=null)
            {
                if (_context.Comments.Find(Id)!=null)
                {
                    Comment comment = _context.Comments.Include(c => c.CommentPost).FirstOrDefault(c => c.Id == Id);
                    List<Comment> comment1 = _context.Comments.Include(c => c.CommentPost).Where(c=>c.ParentCommentId==comment.Id).ToList();
                    CommentPost commentPost = comment.CommentPost;
                    List<CommentPost> commentPost2 = comment1.Select(c => c.CommentPost).ToList();
                    _context.CommentPosts.Remove(commentPost);
                    foreach (var m in comment1)
                    {
                        _context.Comments.Remove(m);
                    }

                    foreach (var m in commentPost2)
                    {
                        _context.CommentPosts.Remove(m);
                    }

                    _context.Comments.Remove(comment);
                    _context.SaveChanges();
                    return RedirectToAction("Detail", new { Id = (int)TempData["IdForAction"] });
                }
                else
                {
                    TempData["CommentError"] = "Such an id does not exist";
                    return RedirectToAction("Detail", new { Id = (int)TempData["IdForAction"] });
                }
            }
            else
            {
                TempData["CommentError"] = "Id must not be null";
                return RedirectToAction("Detail", new { Id = (int)TempData["IdForAction"] });
            }
        }
    }
}
