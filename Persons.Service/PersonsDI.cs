using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInfrastructure;
using Microsoft.Extensions.DependencyInjection;
using Persons.Infrastructure;
using Persons.Service.Imp;

namespace Persons.Service
{
    public static class PersonsDI
    {
        public static IServiceCollection AddMediatorPersons(this IServiceCollection services)
        {
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(PersonsDI).Assembly));
            return services;
        }

        public static IServiceCollection AddDIPersons(this IServiceCollection services) 
        {
            services.AddSingleton<PersonsDBContext>();
            services.AddScoped<IUnitOfWork<PersonsDBContext>, UnitOfWork<PersonsDBContext>>();
            services.AddScoped<IPersonService, PersonServiceMediator>();

            return services;
        }
    }
}
