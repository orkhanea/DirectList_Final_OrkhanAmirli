using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmRegister
    {
        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(30), Required]
        public string Surname { get; set; }

        [MaxLength(15), Required]
        public string UserName { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(40), Required]
        public string Password { get; set; }
    }
}
