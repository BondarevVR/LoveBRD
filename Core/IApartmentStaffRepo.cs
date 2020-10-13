using LoveBRD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core
{
    interface IApartmentStaffRepo
    {
        Task<IEnumerable<ApartmentType>> GetTypes();
        Task<IEnumerable<ApartmentFeature>> GetFeatures();
    }
}
