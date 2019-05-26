using AutoMapper;
using FazendaBrasil.Business.ValueObjects;
using FazendaBrasil.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<FrequencyVO, Frequency>().ReverseMap();            
        }
    }
}
