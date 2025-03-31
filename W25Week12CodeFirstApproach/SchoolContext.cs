using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25Week12CodeFirstApproach
{
    // context class
    // bridge between the app and the database
    public class SchoolContext : DbContext
    {
        // step 1 - define connection string - (required)
        // override the OnConfiguring method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB; Database=SchoolCF;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }


        // step 2 - define entity sets - (required)
        // create the DbSet<> properties
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


        // step 3 - data seeding - (optional)
        // override the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard() { StandardId = 1, StandardName = "Standard 1" },
                new Standard() { StandardId = 2, StandardName = "Standard 2" },
                new Standard() { StandardId = 3, StandardName = "Standard 3" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Name = "John", StandardId = 1 },
                new Student() { StudentId = 2, Name = "Anne", StandardId = 1 },
                new Student() { StudentId = 3, Name = "Mark", StandardId = 2 },
                new Student() { StudentId = 4, Name = "Tina", StandardId = 3 }
            );
        }
    }
}
