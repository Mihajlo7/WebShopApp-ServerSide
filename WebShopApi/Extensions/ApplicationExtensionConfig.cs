using ConnectonService;
using GenericInfrastructure;
using Microsoft.Identity.Client;
using Persons.Infrastructure;
using Persons.Service;
using Persons.Service.Imp;

namespace WebShopApi.Extensions
{
    public static class ApplicationExtensionConfig
    {
        public static void ConfigDatabaseConnection(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("Secret/databases.secret.json", optional: true, reloadOnChange: true);
            });
           
        }
        public static void ConfigConnectionService(this IServiceCollection services)
        {
            services.AddSingleton<ConnectionService>();
        }
        

        
    }
}
