using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30), Required]
        public string FirstName { get; set; }

        [MaxLength(30), Required]
        public string LastName { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }





    }
}
