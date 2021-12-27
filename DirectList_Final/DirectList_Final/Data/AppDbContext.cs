using DirectList_Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuToRestourant> MenuToRestourants { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restourant> Restourants { get; set; }
        public DbSet<RestourantComment> RestourantComments { get; set; }
        public DbSet<RestourantFeature> RestourantFeatures { get; set; }
        public DbSet<RestourantFeatureToRestourant> RestourantFeatureToRestourants { get; set; }
        public DbSet<RestourantMenager> RestourantMenagers { get; set; }
        public DbSet<RestourantTag> RestourantTags { get; set; }
        public DbSet<RestourantTagToRestourant> RestourantTagToRestourants { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
    }
}
