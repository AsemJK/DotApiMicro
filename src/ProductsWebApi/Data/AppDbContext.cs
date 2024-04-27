using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using ProductsWebApi.Data.Models;

namespace ProductsWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var databaseCreator = Database.GetService<IRelationalDatabaseCreator>();
            if (!databaseCreator.CanConnect())
                databaseCreator.Create();
            if (!databaseCreator.HasTables())
                databaseCreator.CreateTables();
        }

        public DbSet<Product> Products { get; set; }
    }
}
