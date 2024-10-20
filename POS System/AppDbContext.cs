using Microsoft.EntityFrameworkCore;
using POS_System.Classes;

namespace POS_System
{
    public class AppDbContext : DbContext
    {
        public DbSet<POSUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Db/data.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set the primary key
            modelBuilder.Entity<POSUser>().HasKey(u => u.UserID);

            // add dummy data, added when "dotnet ef database update" is run
            modelBuilder.Entity<POSUser>().HasData(
                new POSUser { UserID = 1, Password = "password", Name = "Jane Doe", UserType = 0 },  // crew
                new POSUser { UserID = 2, Password = "password", Name = "John Doe", UserType = 1 },   // team lead
                new POSUser { UserID = 3, Password = "password", Name = "Ronald McDonald", UserType = 2 } // manager
            );
        }

    }
}
