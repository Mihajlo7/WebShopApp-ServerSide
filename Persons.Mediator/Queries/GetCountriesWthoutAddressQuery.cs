using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMediator;
using Persons.Core.Dto;

namespace Persons.Mediator.Queries
{
    public sealed record GetCountriesWthoutAddressQuery() : IQuery<IEnumerable<CountryWithoutAddressDTO>>;
}
