using System.Reflection;

namespace NorthWind.EFCore.Repositories.Context
{
    internal class NorthWindContext : DbContext
    {
        //Add-migration InitialCreate -p Northwind.EFCore.Repositories -s Northwind.EFCore.Repositories -c NorthWindContext
        // Update-Database -p Northwind.EFCore.Repositories -s Northwind.EFCore.Repositories -context NorthWindContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JDAGUILAR030306\\SQLEXPRESS; Database=NorthwindNet20; TrustServerCertificate=true; user=Sa; password=nexos");
        }


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
