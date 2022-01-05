﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class SiteSocial
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(100), Required]
        public string Link { get; set; }

        [MaxLength(50),Required]
        public string Icon { get; set; }

    }
}
