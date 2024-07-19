using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMediator;
using Persons.Domain.Domain;

namespace Persons.Mediator.Queries
{
    public sealed record GetCountryByCountryCodeQuery(string countryCode) : IQuery<Country>;
    
}
