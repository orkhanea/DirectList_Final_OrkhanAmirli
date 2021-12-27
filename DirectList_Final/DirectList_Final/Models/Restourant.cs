using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Restourant
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        public string Text { get; set; }

        [MaxLength(30)]
        public string ReceptionPhone { get; set; }

        [MaxLength(30)]
        public string CompaintPhone { get; set; }

        [MaxLength(30)]
        public string SupportPhone { get; set; }

        [MaxLength(500)]
        public string LocationOnMap { get; set; }

        public string LocationDesc { get; set; }

        public DateTime OpeningTime { get; set; }

        public DateTime ClosingTime { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }

        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [ForeignKey("RestourantMenager")]
        public int RestourantMenagerId { get; set; }
        public RestourantMenager RestourantMenager { get; set; }

        public List<MenuToRestourant> MenuToRestourants { get; set; }

        public List<RestourantTagToRestourant> RestourantTagToRestourants { get; set; }

        public List<RestourantFeatureToRestourant> RestourantFeatureToRestourants { get; set; }

        public List<RestourantComment> RestourantComments { get; set; }

        public List<Reservation> Reservations { get; set; }


    }
}
