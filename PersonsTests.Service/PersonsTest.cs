using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GenericInfrastructure;
using Moq;
using NUnit.Framework;
using Persons.Core.Dto.Registration.Request;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Mediator.Commands;
using Persons.Mediator.Handlers;

namespace PersonsTests.Service
{
    [TestFixture]
    internal class PersonsTest
    {
        private Mock<IUnitOfWork<PersonsDBContext>> _unitOfWorkMock;
        private Mock<IValidator<RegisterPersonDTO>> _validatorMock;
        private RegisterPersonHandler _handler;

        [SetUp]
        public void SetUp()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork<PersonsDBContext>>();
            _validatorMock = new Mock<IValidator<RegisterPersonDTO>>();
            _handler = new RegisterPersonHandler(_unitOfWorkMock.Object, _validatorMock.Object);
        }

        [Test]
        public void TestForTest()
        {
            var expected = 1;
            var actual = 1;
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public async Task Handle_ValidRequest_ShouldReturnSuccessResponse()
        {
            // Arrange
            var registerPersonDTO = new RegisterPersonDTO
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDay = new DateTime(1990, 1, 1),
                Telephone = "123456789",
                EmailAddress = new EmailAddressDTO { Email = "john.doe@example.com", EmailPromotion = 2 },
                Password = new PasswordDTO { NewPassword = "StrongPassword123!" },
                Address = new AddressDTO { AddressLine1 = "123 Main St", CountryCode = "US" },
                CreditCard = new CreditCardDTO { Type = "Visa", Number = "4111111111111111", ExpMonth = 12, ExpYear = 2024 }
            };

            _validatorMock.Setup(v => v.ValidateAsync(It.IsAny<RegisterPersonDTO>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

            _unitOfWorkMock.Setup(u => u.GetRepository<Country>().GetSingleOrDefaultAsync(c=>c.Code==registerPersonDTO.Address.CountryCode))
               .ReturnsAsync(new Country { Code = "US" });

            _unitOfWorkMock.Setup(u => u.GetRepository<Person>().Add(It.IsAny<Person>()));

            // Act
            var response = await _handler.Handle(new RegisterPersonCommand(registerPersonDTO), CancellationToken.None);

            // Assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Id, Is.EqualTo(response.Id));
            Assert.That(response.Message, Is.EqualTo("Registration has been succefull!"));
        }
    }
}
