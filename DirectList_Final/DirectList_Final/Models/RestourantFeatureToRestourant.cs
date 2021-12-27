using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class RestourantFeatureToRestourant
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RestourantFeature")]
        public int RestourantFeatureId { get; set; }
        public RestourantFeature RestourantFeature { get; set; }

        [ForeignKey("Restourant")]
        public int RestourantId { get; set; }
        public Restourant Restourant { get; set; }

    }
}
