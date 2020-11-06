using LoveBRD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core.Models.ApartmentModel
{
    public class ApartmentFeature
    {
        public int ApartmentId { get; set; }
        public int FeatureId { get; set; }
        public Apartment Apartment { get; set; }
        public Feature Feature { get; set; }
    }
}
