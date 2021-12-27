using DirectList_Final.Data;
using DirectList_Final.Models;
using DirectList_Final.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlog model = new();
            model.Blog = _context.Blogs.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Blog Deatil");
            model.Setting = _context.Settings.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            return View(model);
        }

        public IActionResult SingleBlog(int? Id)
        {
            if (Id!=null)
            {
                VmBlog model = new();
                if (model!=null)
                {
                    ViewBag.LastestBlogs = _context.Blogs.Take(3).OrderByDescending(b => b.CreatedDate).ToList();
                    model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Blog Deatil");
                    model.Setting = _context.Settings.FirstOrDefault();
                    model.SiteSocial = _context.SiteSocials.ToList();
                    model.SingleBlog1 = _context.Blogs.Include(cu => cu.CustomUser)
                                             .Include(c => c.Comments)
                                             .ThenInclude(cp => cp.CommentPost).FirstOrDefault(p => p.Id == Id);
                    return View(model);

                }

                return RedirectToAction("Index");
               
            }
            

            return RedirectToAction("Index");
        }

        public IActionResult PostComment(CommentPost commentPost)
        {
            if (ModelState.IsValid)
            {
                _context.CommentPosts.Add(commentPost);
                _context.SaveChanges();

                Comment comment = new();
                comment.BlogId = commentPost.BlogId;
                comment.CommentPostId = commentPost.Id;
                comment.CreatedDate = DateTime.Now;
                comment.Content = commentPost.Content;

                if (commentPost.CommentId > 0)
                {
                    comment.ParentCommentId = commentPost.CommentId;
                }

                _context.Comments.Add(comment);
                _context.SaveChanges();

                
            }
                
                return RedirectToAction("SingleBlog", new { Id = commentPost.BlogId });
            
        }
    }
}
