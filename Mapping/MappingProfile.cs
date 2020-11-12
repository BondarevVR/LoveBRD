using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LoveBRD.Controllers.Resourses;
using LoveBRD.Core.Models;
using LoveBRD.Models;

namespace LoveBRD.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // From models to resourses
            CreateMap<_Type, KeyValuePairResourse>();
            CreateMap<Feature, KeyValuePairResourse>();
            CreateMap<Contacts, ContactResourse>();
            CreateMap<Apartment, ApartmentResourse>()
                .ForMember(ar => ar.Features, opt => opt.MapFrom(a => a.Features.Select(af => new KeyValuePairResourse { Id = af.Feature.Id, Name = af.Feature.Name })));

            //From resourses to models
        }
    }
}
