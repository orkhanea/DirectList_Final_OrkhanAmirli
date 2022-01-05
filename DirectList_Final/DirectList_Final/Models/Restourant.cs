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

        [MaxLength(50), Required]
        public string Name { get; set; }

        [MaxLength(150), Required]
        public string Address { get; set; }

        [Required]
        public string Text { get; set; }

        [MaxLength(30), Required]
        public string ReceptionPhone { get; set; }

        [MaxLength(30)]
        public string CompaintPhone { get; set; }

        [MaxLength(30)]
        public string SupportPhone { get; set; }

        [MaxLength(500), Required]
        public string LocationOnMap { get; set; }

        [Required]
        public string LocationDesc { get; set; }

        [Required]
        public DateTime OpeningTime { get; set; }

        [Required]
        public DateTime ClosingTime { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }

        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [MaxLength(30), Required]
        public string ManagerName { get; set; }

        [MaxLength(30), Required]
        public string ManagerSurName { get; set; }

        [MaxLength(30), Required]
        public string ManagerPhone { get; set; }

        [MaxLength(50), Required]
        public string ManagerEmail { get; set; }

        [MaxLength(50)]
        public string ManagerWebSite { get; set; }

        [MaxLength(250)]
        public string ManagerImage { get; set; }

        [NotMapped]
        public IFormFile ManagerImageFile { get; set; }

        [NotMapped]
        public List<int> RestourantTagToRestourantId { get; set; }

        [NotMapped]
        public List<int> RestourantFeatureToRestourantId { get; set; }

        [NotMapped]
        public List<int> MenuToRestourantId { get; set; }

        public List<MenuToRestourant> MenuToRestourants { get; set; }

        public List<RestourantTagToRestourant> RestourantTagToRestourants { get; set; }

        public List<RestourantFeatureToRestourant> RestourantFeatureToRestourants { get; set; }

        public List<RestourantComment> RestourantComments { get; set; }

        public List<Reservation> Reservations { get; set; }


    }
}
