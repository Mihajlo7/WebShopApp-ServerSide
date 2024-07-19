using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Registration.Request;

namespace Persons.Validators.Validators
{
    internal class CreditCardValidator : AbstractValidator<CreditCardDTO>
    {
        public CreditCardValidator()
        {
            RuleFor(creditCard=>creditCard.Number)
                .NotEmpty()
                .Matches(@"^\d{4}-\d{4}-\d{4}-\d{4}$")
                .WithMessage("Invalid credit card");

            RuleFor(creditCard => creditCard.ExpMonth)
                .NotEmpty()
                .ExclusiveBetween(1,12)
                .WithMessage("Invalid month");

            RuleFor(creditCard => creditCard.ExpYear)
                .NotEmpty()
                .GreaterThan(DateTime.Now.Year)
                .WithMessage("Invalid year card");

            RuleFor(creditCard => creditCard.Type).NotEmpty();
        }
    }
}
