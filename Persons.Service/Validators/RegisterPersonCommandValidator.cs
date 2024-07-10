using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Service.Mediator.Commands;

namespace Persons.Service.Validators
{
    public sealed class RegisterPersonCommandValidator : AbstractValidator<RegisterPersonCommand>
    {
        public RegisterPersonCommandValidator()
        {
            RuleFor(x=>x.registerPerson.FirstName).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(x=>x.registerPerson.LastName).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(x => x.registerPerson.BirthDay).NotNull();
            RuleFor(x=>x.registerPerson.Telephone).NotNull().NotEmpty();
            RuleFor(x=>x.registerPerson.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x=>x.registerPerson.Password).NotNull().NotEmpty();
            RuleFor(x=>x.registerPerson.ConfirmedPassword).NotNull().NotEqual("Potrebno je ovo promeniti");
        }
    }
}
