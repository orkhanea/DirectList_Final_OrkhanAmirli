using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string MenuName { get; set; }

        public List<MenuToRestourant> MenuToRestourants { get; set; }
    }
}
