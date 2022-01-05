using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Title { get; set; }

        [MaxLength(100), Required]
        public string BlogInfo { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }

        public CustomUser CustomUser { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
