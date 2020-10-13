using LoveBRD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core
{
    public interface IApartmentStaffRepo
    {
        public Task<IEnumerable<ApartmentType>> GetTypes();
        public Task<IEnumerable<ApartmentFeature>> GetFeatures();
    }
}
