using ConnectonService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Products.Core.Domain;

namespace Products.Infrastructure
{
    public class ProductsDBContext : DbContext
    {
        private readonly ConnectionService _connectionService;

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SizeUnitOfMeasure> SizeUnits { get; set; }
        public DbSet<WeightUnitOfMeasure> WeightUnits { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public ProductsDBContext(ConnectionService connectionService)
        {
            _connectionService = connectionService; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionService.GetProductsConnection())
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
