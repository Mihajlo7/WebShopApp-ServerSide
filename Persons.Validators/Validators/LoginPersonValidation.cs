using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Login;

namespace Persons.Validators.Validators
{
    public class LoginPersonValidation : AbstractValidator<LoginPersonDTO>
    {
        public LoginPersonValidation() 
        {
            RuleFor(person=>person.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email is Required");

            RuleFor(person => person.Password)
                .NotEmpty()
                .WithMessage("Password is required");
        }
    }
}
