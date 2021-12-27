using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class MenuToRestourant
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Ingrediend { get; set; }

        [DataType(DataType.Currency)]
        public float Price { get; set; }

        [ForeignKey("Restourant")]
        public int RestourantId { get; set; }
        public Restourant Restourant { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

    }
}
