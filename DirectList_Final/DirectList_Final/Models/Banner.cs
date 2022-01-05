using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Title { get; set; }

        [MaxLength(50), Required]
        public string SubTitle { get; set; }

        [MaxLength(20), Required]
        public string Page { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
