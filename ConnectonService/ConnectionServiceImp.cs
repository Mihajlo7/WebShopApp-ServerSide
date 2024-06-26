using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ConnectonService
{
    public class ConnectionServiceImp
    {
        private readonly IConfiguration _configuration;

        private string personsDatabase;
        private string productsDatabase;

        public ConnectionServiceImp(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetPersonsConnection()
        {
            personsDatabase = _configuration["Modules:Persons:SqlServer"];
            return personsDatabase;
        }
    }
}
