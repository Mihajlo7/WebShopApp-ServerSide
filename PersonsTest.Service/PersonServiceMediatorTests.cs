using MediatR;
using Moq;
using Persons.Core.Dto.Registration.Request;
using Persons.Core.Dto.Registration.Response;
using Persons.Mediator.Commands;
using Persons.Service;
using Persons.Service.Imp;
using Xunit;

namespace PersonsTest.Service
{
    public class PersonServiceMediatorTests
    {
        private readonly Mock<IMediator> _mediatorMock;
        private readonly IPersonService _service;

        public PersonServiceMediatorTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _service= new PersonServiceMediator( _mediatorMock.Object );
        }

        [Fact]
        public async Task Register_ValidRequest_ShouldReturnSuccess()
        {
            // Arrange
            var registerPersonDTO = new RegisterPersonDTO
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDay = new DateTime(1990, 1, 1),
                Telephone = "123456789",
                EmailAddress = new EmailAddressDTO { Email = "john.doe@example.com", EmailPromotion = 2 },
                Password = new PasswordDTO { NewPassword = "SecurePassword123!" },
                Address = new AddressDTO
                {
                    AddressLine1 = "123 Main St",
                    AddressLine2 = "Apt 4B",
                    City = "Metropolis",
                    PostalCode = "12345",
                    CountryCode = "US"
                },
                CreditCard = new CreditCardDTO { Type = "Visa", Number = "4111111111111111", ExpMonth = 12, ExpYear = 2030 }
            };

            var expectedResponse = new RegisterResponseDTO
            {
                Id = Guid.NewGuid().ToString(),
                Message = "Registration has been succefull!"
            };

            _mediatorMock.Setup(m => m.Send(It.IsAny<RegisterPersonCommand>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(expectedResponse);

            // Act
            var response = await _service.Register(registerPersonDTO);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Message, response.Message);
            Assert.Equal(expectedResponse.Id, response.Id);
        }
        [Fact]
        public void UnitTest()
        {

        }
    }
}
