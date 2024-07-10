using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using GenericInfrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Persons.Infrastructure;
using Persons.Service.Imp;
using Persons.Service.Mediator.Commands;
using Persons.Service.Validators;

namespace Persons.Service
{
    public static class PersonsDI
    {
        public static IServiceCollection AddMediatorPersons(this IServiceCollection services)
        {
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(PersonsDI).Assembly));
            //Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }

        public static IServiceCollection AddDIPersons(this IServiceCollection services) 
        {
            services.AddSingleton<PersonsDBContext>();
            services.AddScoped<IUnitOfWork<PersonsDBContext>, UnitOfWork<PersonsDBContext>>();
            services.AddScoped<IPersonService, PersonServiceMediator>();

            return services;
        }
        public static IServiceCollection AddValidatorsPersons(this IServiceCollection services)
        {
            //services.AddValidatorsFromAssembly(typeof(PersonsDI).Assembly);
            services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssemblyContaining<RegisterPersonCommandValidator>();
            return services;
        }
    }
}
