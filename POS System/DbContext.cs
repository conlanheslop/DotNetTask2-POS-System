using Microsoft.EntityFrameworkCore;

namespace POS_System
{
    public class AppDbContext : DbContext
    {
        public DbSet<POSUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./db/data.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add dummy data, added when "dotnet ef database update" is run
            modelBuilder.Entity<POSUser>().HasData(
                new POSUser { Id = 1, Username = "admin", Password = "admin123", Type = "Admin" },
                new POSUser { Id = 2, Username = "user1", Password = "password", Type = "Customer" }
            );
        }

    }
}
