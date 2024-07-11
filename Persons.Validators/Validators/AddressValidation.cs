using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Registration.Request;

namespace Persons.Validators.Validators
{
    public class AddressValidation : AbstractValidator<AddressDTO>
    {
        public AddressValidation()
        {
            RuleFor(address => address.AddressLine1)
                .NotEmpty()
                .WithMessage("Invalid Address");

            RuleFor(address => address.City).NotEmpty();

            RuleFor(address=> address.CountryCode)
                .NotEmpty()
                .Length(2)
                .WithMessage("Invalid Country Code");
        }
    }
}
