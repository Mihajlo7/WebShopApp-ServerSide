using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Persons.Core.Dto;
using Persons.Service.Mediator.Queries;

namespace Persons.Service.Imp
{
    public class PersonServiceMediator : IPersonService
    {
        private readonly IMediator _mediator;

        public PersonServiceMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IEnumerable<CountryWithoutAddressDTO>> GetAllCountries()
        {
            var response = await _mediator.Send(new GetCountriesWthoutAddressQuery());
            return response;
        }

        public Task<RegisterResponseDTO> Register(RegisterPersonDTO registerPerson)
        {
            throw new NotImplementedException();
        }
    }
}
