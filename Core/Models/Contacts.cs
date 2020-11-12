using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core.Models
{
    public class Contacts
    {
        public int ApartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Telephone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

    }
}
