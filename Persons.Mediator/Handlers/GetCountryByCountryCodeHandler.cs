using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInfrastructure;
using GenericMediator;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Mediator.Queries;

namespace Persons.Mediator.Handlers
{
    public sealed class GetCountryByCountryCodeHandler : IQueryHandler<GetCountryByCountryCodeQuery, Country>
    {
        private readonly IUnitOfWork<PersonsDBContext> _unitOfWork;

        public GetCountryByCountryCodeHandler(IUnitOfWork<PersonsDBContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Country> Handle(GetCountryByCountryCodeQuery request, CancellationToken cancellationToken)
        {
            var countryResponse = await _unitOfWork.GetRepository<Country>()
                .GetSingleOrDefaultAsync(country => country.Code == request.countryCode);

            return countryResponse;
        }
    }
}
