using LoveBRD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Core
{
    public interface IApartmentRepo
    {
        public Task<IEnumerable<Apartment>> GetApartmentsAsync();
    }
}
