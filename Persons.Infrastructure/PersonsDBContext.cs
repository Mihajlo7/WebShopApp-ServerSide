using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectonService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persons.Domain.Domain;
using Persons.Infrastructure.Configuration;

namespace Persons.Infrastructure
{
    public class PersonsDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BussinessEntitityCreditCard> BussinessEntitityCreditCards { get; set; }
        public DbSet<BusinessEntityAdress> BusinessEntityAdresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CreditCard> CreditCards { get; set;}
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<Password> Passwords { get; set; }

        private readonly ConnectionServiceImp _connectionService;

        public PersonsDBContext(ConnectionServiceImp connectionService)
        {
            _connectionService = connectionService;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionService.GetPersonsConnection())
                .LogTo(Console.WriteLine,LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
