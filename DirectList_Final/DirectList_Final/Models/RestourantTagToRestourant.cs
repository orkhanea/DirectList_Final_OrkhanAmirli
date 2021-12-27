using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class RestourantTagToRestourant
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RestourantTag")]
        public int RestourantTagId { get; set; }
        public RestourantTag RestourantTag { get; set; }

        [ForeignKey("Restourant")]
        public int RestourantId { get; set; }
        public Restourant Restourant { get; set; }


    }
}
