using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LoveBRD.Controllers.Resourses;
using LoveBRD.Models;

namespace LoveBRD.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // From models to resourses
            CreateMap<ApartmentType, KeyValuePairResourse>();
            CreateMap<ApartmentFeature, KeyValuePairResourse>();

            //From resourses to models
        }
    }
}
