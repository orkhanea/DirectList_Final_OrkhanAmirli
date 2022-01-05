using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Icon { get; set; }

        [Required]
        public string Info { get; set; }

        [MaxLength(500), Required]
        public string ImageText { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
