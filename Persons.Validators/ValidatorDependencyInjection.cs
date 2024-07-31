using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persons.Validators.Validators;

namespace Persons.Validators
{
    public static  class ValidatorDependencyInjection
    {
        public static IServiceCollection AddPersonsValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<PasswordValidation>();
            services.AddValidatorsFromAssemblyContaining<AddressValidation>();
            services.AddValidatorsFromAssemblyContaining<CreditCardValidator>();
            services.AddValidatorsFromAssemblyContaining<EmailAddressValidation>();
            services.AddValidatorsFromAssemblyContaining<RegisterPersonValidation>();
            services.AddValidatorsFromAssemblyContaining<LoginPersonValidation>();

            return services;
        }
    }
}
