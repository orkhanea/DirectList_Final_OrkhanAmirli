using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150), Required]
        public string Address { get; set; }

        [MaxLength(30), Required]
        public string Phone { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

    }
}
