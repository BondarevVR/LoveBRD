using AutoMapper;
using LoveBRD.Controllers.Resourses;
using LoveBRD.Core;
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
        private readonly IApartmentStaffRepo repository;
        private readonly IMapper mapper;

        public ApartmentStaffController(IApartmentStaffRepo repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet("/api/apartTypes")]
        public async Task<IEnumerable<KeyValuePairResourse>> GetTipes() 
        {
            var types = await repository.GetTypes();

            return mapper.Map<IEnumerable<_Type>, IEnumerable<KeyValuePairResourse>>(types);
        }

        [HttpGet("/api/apartFeatures")]
        public async Task<IEnumerable<KeyValuePairResourse>> GetFeatures()
        {
            var features = await repository.GetFeatures();

            return mapper.Map<IEnumerable<Feature>, IEnumerable<KeyValuePairResourse>>(features);
        }
    }
}
