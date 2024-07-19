using Microsoft.Extensions.DependencyInjection;

namespace Persons.Mediator
{
    public static class PersonMediatorDependencyInjection
    {
       public static IServiceCollection AddPersonMediator(this IServiceCollection services)
        {
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(PersonMediatorDependencyInjection).Assembly));
            return services;
        }  
    }
}
