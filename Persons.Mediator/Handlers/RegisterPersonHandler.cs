using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GenericInfrastructure;
using GenericMediator;
using Helpers;
using Persons.Core.Dto.Registration.Request;
using Persons.Core.Dto.Registration.Response;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Mediator.Commands;
using Persons.Validators.Validators;

namespace Persons.Mediator.Handlers
{
    public class RegisterPersonHandler : ICommandHandler<RegisterPersonCommand, RegisterResponseDTO>
    {
        private readonly IUnitOfWork<PersonsDBContext> _unitOfWork;
        private readonly IValidator<RegisterPersonDTO> _validator;
       // private readonly IMapper _mapper;

        public RegisterPersonHandler
            (IUnitOfWork<PersonsDBContext> unitOfWork,
            IValidator<RegisterPersonDTO> validator
            //IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            //_mapper = mapper;
        }

        public async Task<RegisterResponseDTO> Handle(RegisterPersonCommand request, CancellationToken cancellationToken)
        {
            var validatorResponse = await _validator.ValidateAsync(request.registerPerson);

            if (!validatorResponse.IsValid)
            {
                throw new ValidationException(validatorResponse.Errors);
            }

            var nePerson = await createNewPerson(request.registerPerson);

            return new RegisterResponseDTO
            {
                Id = nePerson.Id.ToString(),
                Message="Registration has been succefull!"
            };
        }

        private async Task<Person> createNewPerson(RegisterPersonDTO registerPersonDTO)
        {
            Person person = new Person();
            // Additional information
            person.FirstName = registerPersonDTO.FirstName;
            person.LastName = registerPersonDTO.LastName;
            person.BirthDate = registerPersonDTO.BirthDay;
            person.Telephone = registerPersonDTO.Telephone;
            // Adding Email
            person.EmailAddress =
                new EmailAddress
                {
                    Email = registerPersonDTO.EmailAddress.Email
                ,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    EmailAddressPromotion = registerPersonDTO.EmailAddress.EmailPromotion
                };
            // Adding Password
            person.Passwords = generatePassword(registerPersonDTO.Password);

            // Adding Address
            var country=await _unitOfWork.GetRepository<Country>().GetSingleOrDefaultAsync(country=>country.Code==registerPersonDTO.Address.CountryCode);
            person.Adresses = createAdress(registerPersonDTO.Address,country);
            // Adding Credit Card
            person.CreditCards = createCreditCard(registerPersonDTO.CreditCard);
            // 

            // Add Creation time and Update time
            person.CreatedAt = DateTime.Now;
            person.UpdatedAt = DateTime.Now;

            _unitOfWork.GetRepository<Person>().Add(person);

            await _unitOfWork.CommitChanges();

            return person;
        }

        private ICollection<BusinessEntityAdress> createAdress(AddressDTO address,Country country)
        {
            BusinessEntityAdress entityAdress = new BusinessEntityAdress
            {
                Address = new Address
                {
                    AddressLine1 = address.AddressLine1,
                    AddressLine2 = address.AddressLine2,
                    City = address.City,
                    Country = country,
                    PostalCode = address.PostalCode,
                    CreatedAt= DateTime.Now,
                    UpdatedAt= DateTime.Now,
                },
                CreatedAt= DateTime.Now,
                UpdatedAt= DateTime.Now,
            };
            //return new List<BusinessEntityAdress> {  entityAdress };
            return [entityAdress];
        }

        private ICollection<BussinessEntitityCreditCard> createCreditCard(CreditCardDTO creditCard)
        {
            BussinessEntitityCreditCard creditCardBuss = new BussinessEntitityCreditCard
            {
                CreditCard = new CreditCard
                {
                    Type = creditCard.Type,
                    Number = creditCard.Number,
                    ExpMonth = creditCard.ExpMonth,
                    ExpYear = creditCard.ExpYear,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                CreatedAt= DateTime.Now,
                UpdatedAt= DateTime.Now,

            };
           //return new List<BussinessEntitityCreditCard> { creditCardBuss};
           return [creditCardBuss];

        }

        private ICollection<Password> generatePassword(PasswordDTO password)
        {
            var hash = PasswordMaker.HashPassword(password.NewPassword, out var salt);
            Password createdPassword= 
                new Password 
                {
                    PasswordHash = hash,
                    PasswordSalt= Convert.ToBase64String(salt),
                    IsActive=true,
                    CreatedAt= DateTime.Now,
                    UpdatedAt= DateTime.Now,
                };
            //return new List<Password> { createdPassword };
            return [createdPassword];
        }
    }
}
