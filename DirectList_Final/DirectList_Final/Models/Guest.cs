using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string GuestCount { get; set; }

        public List<Reservation> Reservations { get; set; }


    }
}
