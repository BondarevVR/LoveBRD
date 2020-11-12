using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Controllers.Resourses
{
    public class SaveApartmentResourse
    {
        public int Id { get; set; }
        public KeyValuePairResourse Type { get; set; }
        public byte RoomAmount { get; set; }
        public ICollection<int> FeatureIds { get; set; }
        public int Price { get; set; }
        public ContactResourse Contacts { get; set; }
        public string Adress { get; set; }
        public string AdditionalInformation { get; set; }

        public SaveApartmentResourse()
        {
            FeatureIds = new Collection<int>();
        }
    }
}
