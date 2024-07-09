using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Persons.Core.Dto;

namespace Persons.Service.Mediator.Queries
{
    public record GetCountriesWthoutAddressQuery() : IRequest<IEnumerable<CountryWithoutAddressDTO>>;
    
}
