using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Registration.Request;

namespace Persons.Validators.Validators
{
    public class PasswordValidation : AbstractValidator<PasswordDTO>
    {
        public PasswordValidation()
        {
            RuleFor(password => password.NewPassword)
                .NotEmpty()
                .WithMessage("Password is required");

            RuleFor(password => password.ConfirmedPassword)
                .NotEmpty()
                .WithMessage("ConfirmedPassword is required");

            RuleFor(password=>password)
                .Must(password=> password.ConfirmedPassword==password.NewPassword)
                .WithMessage("Password and confirmed password should be same!");
        }
    }
}
