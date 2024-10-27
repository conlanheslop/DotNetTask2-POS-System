using Microsoft.EntityFrameworkCore;
using POS_System.Classes;

namespace POS_System
{
    public class AppDbContext : DbContext
    {
        public DbSet<POSUser> Users { get; set; }
        public DbSet<POSItem> POSItems { get; set; }
        public DbSet<CompletedOrder> CompletedOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Db/data.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<POSUser>()
                .HasDiscriminator<int>("UserType")  // 'UserType' will differentiate our subclasses
                .HasValue<Crew>(0)                 // crew = 0
                .HasValue<TeamLead>(1)             // teamlead = 1
                .HasValue<Manager>(2);             // manager = 2

            modelBuilder.Entity<POSUser>().HasKey(u => u.UserID); // set the PK


            // initial menu items
            modelBuilder.Entity<POSItem>().HasData(
                new POSItem { ItemID = 1, Name = "Big Mac", Price = 6.50m },
                new POSItem { ItemID = 2, Name = "Medium Fries", Price = 3.20m },
                new POSItem { ItemID = 3, Name = "Coke", Price = 4.50m },
                new POSItem { ItemID = 4, Name = "Coke No Sugar", Price = 4.50m },
                new POSItem { ItemID = 5, Name = "Oreo McFlurry", Price = 4.75m },
                new POSItem { ItemID = 6, Name = "M&M McFlurry", Price = 4.75m }
            );


            // initial user dummy data
            modelBuilder.Entity<Crew>().HasData(
                new Crew(1, "password", "Ronald McDonald")
            );


            modelBuilder.Entity<TeamLead>().HasData(
                new TeamLead(2, "password", "The Hamburgler")
            );


            modelBuilder.Entity<Manager>().HasData(
                new Manager(3, "password", "Grimace")
            );
        }
    }
}
