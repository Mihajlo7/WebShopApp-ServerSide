using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Persons.Core.Dto;
using Persons.Core.Dto.Registration.Request;
using Persons.Core.Dto.Registration.Response;
using Persons.Mediator.Commands;
using Persons.Mediator.Queries;


namespace Persons.Service.Imp
{
    public class PersonServiceMediator : IPersonService
    {
        private readonly IMediator _mediator;
        //private readonly IValidator<RegisterPersonDTO> _validator;

        public PersonServiceMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IEnumerable<CountryWithoutAddressDTO>> GetAllCountries()
        {
            var response = await _mediator.Send(new GetCountriesWthoutAddressQuery());
            return response;
        }

        public async Task<RegisterResponseDTO> Register(RegisterPersonDTO registerPerson)
        {
            var response = await _mediator.Send(new RegisterPersonCommand(registerPerson));
            return response;
        }
    }
}
