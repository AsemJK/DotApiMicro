using DotApiMicro.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DotApiMicro.Data
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
