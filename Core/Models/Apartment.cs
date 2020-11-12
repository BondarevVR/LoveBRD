using LoveBRD.Core.Models.ApartmentModel;
using LoveBRD.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        [Required]
        public _Type Type { get; set; }
        public byte RoomAmount { get; set; } //бизнес логика // не ебу пока как ее правильно сделать
        public ICollection<ApartmentFeature> Features { get; set; }
        [Required]
        public int Price { get; set; }
        public Contacts Contacts { get; set; }
        [Required]
        public string Adress { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime LastUpdate { get; set; }

        public Apartment()
        {
            Features = new Collection<ApartmentFeature>();
        }
    }
}
