using LoveBRD.Core;
using LoveBRD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Persistance
{
    public class ApartmentStaffRepo : IApartmentStaffRepo
    {
        private readonly AppDBContext context;

        public ApartmentStaffRepo(AppDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<_Type>> GetTypes () 
        {
            return await context.Types.ToListAsync();
        }
        public async Task<IEnumerable<Feature>> GetFeatures()
        {
            return await context.Features.ToListAsync();
        }
    }
}
