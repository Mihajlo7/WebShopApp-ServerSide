using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace LoggingConfiguration
{
    public static class SerilogLoggingConfig
    {
        public static void  CreateLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File($"logs/{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}_log.txt")
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();
        }
        public static void ConfigureCustomLogging(this IHostBuilder host)
        {
            CreateLogger();
            host.UseSerilog(Log.Logger);

        }
    }
}
