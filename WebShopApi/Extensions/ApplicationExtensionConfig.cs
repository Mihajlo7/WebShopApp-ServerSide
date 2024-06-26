using ConnectonService;
using Microsoft.Identity.Client;

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
            services.AddSingleton<ConnectionServiceImp>();
        }
    }
}
