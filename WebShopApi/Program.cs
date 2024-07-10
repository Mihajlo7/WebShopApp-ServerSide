using GlobalExceptionHandlerNew;
using Persons.Service;
using WebShopApi.Extensions;
namespace WebShopApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
                      
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Host.ConfigDatabaseConnection();
            builder.Services.AddMediatorPersons();
            builder.Services.AddDIPersons();
            builder.Services.AddValidatorsPersons();
            builder.Services.ConfigConnectionService();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.UseMiddleware<ExceptionHandler>();

            app.Run();
        }
    }
}
