using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class RestourantTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20),Required]
        public string Name { get; set; }

        public List<RestourantTagToRestourant> RestourantTagToRestourants { get; set; }

    }
}
