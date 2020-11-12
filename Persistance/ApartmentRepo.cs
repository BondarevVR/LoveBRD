using LoveBRD.Core;
using LoveBRD.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Persistance
{
    public class ApartmentRepo: IApartmentRepo
    {
        private readonly AppDBContext context;

        public ApartmentRepo(AppDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsAsync() 
        {
            return await context.Apartments.ToListAsync();
        }
    }
}
