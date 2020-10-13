using AutoMapper;
using LoveBRD.Controllers.Resourses;
using LoveBRD.Mapping;
using LoveBRD.Models;
using LoveBRD.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Controllers
{
    public class ApartmentStaffController
    {
        private readonly AppDBContext context;
        private readonly IMapper mapper;

        public ApartmentStaffController(AppDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/types")]
        public async Task<IEnumerable<KeyValuePairResourse>> GetTipes() 
        {
            var types = await context.Types.ToListAsync();

            return mapper.Map<List<Models.Type>, List<KeyValuePairResourse>>(types);
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResourse>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<KeyValuePairResourse>>(features);
        }
    }
}
