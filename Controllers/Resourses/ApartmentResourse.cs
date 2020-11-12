using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Controllers.Resourses
{
    public class ApartmentResourse
    {
        public int Id { get; set; }
        public KeyValuePairResourse Type { get; set; }
        public byte RoomAmount { get; set; }
        public ICollection<KeyValuePairResourse> Features { get; set; }
        public int Price { get; set; }
        public ContactResourse Contacts { get; set; }
        public string Adress { get; set; }
        public string AdditionalInformation { get; set; }

        public ApartmentResourse()
        {
            Features = new Collection<KeyValuePairResourse>();
        }
    }
}
