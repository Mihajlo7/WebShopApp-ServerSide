using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Persons.Core.Dto;
using Persons.Domain.Domain;

namespace Persons.Core.Mapper
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<Country, CountryWithoutAddressDTO>();
        }
    }
}
