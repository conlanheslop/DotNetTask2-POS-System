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
            modelBuilder.Entity<POSUser>()
                .HasDiscriminator<int>("UserType")  // 'UserType' will differentiate our subclasses
                .HasValue<Crew>(0)                 // crew = 0
                .HasValue<TeamLead>(1)             // teamlead = 1
                .HasValue<Manager>(2);             // manager = 2

            // set the PK
            modelBuilder.Entity<POSUser>().HasKey(u => u.UserID);


            // initial dummy data
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
