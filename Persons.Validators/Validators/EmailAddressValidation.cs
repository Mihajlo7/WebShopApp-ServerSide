using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Persons.Core.Dto.Registration.Request;

namespace Persons.Validators.Validators
{
    public class EmailAddressValidation : AbstractValidator<EmailAddressDTO>
    {
        public EmailAddressValidation()
        {
            RuleFor(emailAddress=>emailAddress.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(emailAddress => emailAddress.EmailPromotion)
                .NotEmpty()
                .ExclusiveBetween(1, 10)
                .WithMessage("Invalid Email Promotion");
        }
    }
}
