using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Registration.Request;

namespace Persons.Validators.Validators
{
    public class RegisterPersonValidation : AbstractValidator<RegisterPersonDTO>
    {
        public RegisterPersonValidation()
        {
            RuleFor(person=>person.FirstName)
                .NotEmpty()
                .WithMessage("FirstName is required");

            RuleFor(person => person.LastName)
                .NotEmpty()
                .WithMessage("LastName is required");

            RuleFor(person => person.BirthDay)
                .NotEmpty()
                .WithMessage("Birthday is required");

            RuleFor(person => person.Telephone)
                .NotEmpty()
                .Matches(@"^\d{10}$")
                .WithMessage("Invalid telephone format");

            RuleFor(person => person.EmailAddress)
                .NotNull()
                .SetValidator(new EmailAddressValidation());

            RuleFor(person=>person.Password)
                .NotNull()
                .SetValidator(new PasswordValidation());

            RuleFor(person => person.Address)
                .SetValidator(new AddressValidation());

            RuleFor(person => person.CreditCard)
                .SetValidator(new CreditCardValidator());
        }
    }
}
