using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInfrastructure;
using GenericMediator;
using Helpers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using Persons.Core.Dto.Registration.Response;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Service.Mediator.Commands;

namespace Persons.Service.Mediator.Handlers
{
    public class RegisterPersonHandler : ICommandHandler<RegisterPersonCommand, RegisterResponseDTO>
    {
        private readonly IUnitOfWork<PersonsDBContext> _unitOfWork;

        public RegisterPersonHandler(IUnitOfWork<PersonsDBContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;  
        }
        public  async Task<RegisterResponseDTO> Handle(RegisterPersonCommand request, CancellationToken cancellationToken)
        {
            
            //var createdPerson= _unitOfWork.GetRepository<Person>().Add(newPerson);
            var newEmailAddress = new EmailAddress
            {
                Email = request.registerPerson.Email,
                EmailAddressPromotion = 2,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            var newPassword = CreatePassword(request.registerPerson.Password);

            var newPerson = new Person
            {
                FirstName = request.registerPerson.FirstName,
                LastName = request.registerPerson.LastName,
                Telephone = request.registerPerson.Telephone,
                EmailAddress = newEmailAddress,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            newPerson.Passwords=new LinkedList<Password>();
            newPerson.Passwords.Add(newPassword);
            var response= _unitOfWork.GetRepository<Person>().Add(newPerson);

            await _unitOfWork.CommitChanges();
            return new RegisterResponseDTO { Id = response.Id.ToString(), Message = "Person has succefully registred." };
        }

        private Password CreatePassword(string password)
        {
            var hash = PasswordMaker.HashPassword(password, out var salt);
            return new Password
            {
                PasswordHash = hash,
                PasswordSalt = Convert.ToHexString(salt),
                IsActive = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }
    }
}
