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
using Persons.Mediator;
using Persons.Service.Imp;
using Persons.Validators;


namespace Persons.Service
{
    public static class PersonsDI
    {
        

        public static IServiceCollection AddDIPersons(this IServiceCollection services) 
        {
            services.AddSingleton<PersonsDBContext>();
            services.AddScoped<IUnitOfWork<PersonsDBContext>, UnitOfWork<PersonsDBContext>>();
            services.AddScoped<IPersonService, PersonServiceMediator>();

            services.AddPersonMediator();
            services.AddPersonsValidators();

            return services;
        }
        
    }
}
