using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GenericInfrastructure;
using GenericMediator;
using Helpers;
using Persons.Core.Dto.Login;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Mediator.Commands;
using Persons.Validators.Validators;

namespace Persons.Mediator.Handlers
{
    public class LoginPersonHandler : ICommandHandler<LoginPersonCommand, LoginResponseDTO>
    {
        private readonly IValidator<LoginPersonDTO> _validator;
        private readonly IUnitOfWork<PersonsDBContext> _unitOfWork;

        public LoginPersonHandler(IValidator<LoginPersonDTO> validator,IUnitOfWork<PersonsDBContext> unitOfWork)
        {
            _validator = validator;
            _unitOfWork = unitOfWork;
        }
        public async Task<LoginResponseDTO> Handle(LoginPersonCommand request, CancellationToken cancellationToken)
        {
            var validatorResponse = await _validator.ValidateAsync(request.loginPerson);

            if (!validatorResponse.IsValid)
            {
                throw new ValidationException(validatorResponse.Errors);
            }
            bool found = false;
            var foundedPerson = await _unitOfWork.GetRepository<Person>()
                .GetSingleOrDefaultAsync(person => person.EmailAddress.Email == request.loginPerson.Email);
            var name = foundedPerson.FirstName;
            if (foundedPerson != null)
            {
                var passwordPerson =
                    await _unitOfWork.GetRepository<Password>().GetSingleOrDefaultAsync(password =>
                    password.PersonId == foundedPerson.Id);
                var salt = passwordPerson.PasswordSalt;
                var hash = passwordPerson.PasswordHash;
                if(PasswordMaker.VerifyPassword(request.loginPerson.Password, passwordPerson.PasswordHash, Convert.FromBase64String(passwordPerson.PasswordSalt)))
                {
                    found = true;
                }
            }
            
            if (found)
            {
                return new LoginResponseDTO { Success= true, Message="Email and password is correct" };
            }
            else
            {
                return new LoginResponseDTO { Success = false, Message = "Email or password is incorrect" };
            }
        }
    }
}
