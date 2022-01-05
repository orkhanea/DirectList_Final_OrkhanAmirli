using DirectList_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList_Final.ViewModel
{
    public class VmMenu
    {
        public List<Menu> Menus { get; set; }
        public List<MenuToRestourant> MenuToRestourants { get; set; }
        public List<Restourant> Restourants { get; set; }
        public Restourant Restourants2 { get; set; }

        [Required(ErrorMessage = "Please select Menu")]
        public int MenuNameId { get; set; }

        [MaxLength(250)]
        public string MenuIngrediend { get; set; }

        [DataType(DataType.Currency)]
        public float MenuPrice { get; set; }
        public int RestourantId { get; set; }
    }
}
