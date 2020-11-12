using AutoMapper;
using LoveBRD.Core;
using LoveBRD.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Controllers.Resourses
{
    public class ApartmentsController
    {
        private readonly IApartmentRepo repository;
        private readonly IMapper mapper;

        public ApartmentsController(IApartmentRepo repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        /*[HttpPost("/api/apartment")]
        public IActionResult CreateApartment([FromBody] ApartmentResourse apartmentResource) 
        { 
            
        }*/

        [HttpGet("/api/vehicles")]
        public async Task<IEnumerable<ApartmentResourse>> GetApartments() 
        {
            var apartments = await repository.GetApartmentsAsync();
            var apartmentResources = mapper.Map<IEnumerable<Apartment>, IEnumerable<ApartmentResourse>>(apartments);

            return apartmentResources;
        }
    }
}
