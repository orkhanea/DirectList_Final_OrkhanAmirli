using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(20)]
        public string IdentityNo { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }

        public DateTime ReservationTime { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        public Guest Guest { get; set; }

        [ForeignKey("Restourant")]
        public int RestourantId { get; set; }
        public Restourant Restourant { get; set; }





    }
}
