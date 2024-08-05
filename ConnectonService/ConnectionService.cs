using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ConnectonService
{
    public class ConnectionService
    {
        private readonly IConfiguration _configuration;

        private string personsDatabase;
        private string productsDatabase;

        public ConnectionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetPersonsConnection()
        {
            personsDatabase = _configuration["Modules:Persons:SqlServer"];
            return personsDatabase;
        }

        public string GetProductsConnection()
        {
            productsDatabase = _configuration["Modules:Products:SqlServer"];
            return productsDatabase;
        }
    }
}
