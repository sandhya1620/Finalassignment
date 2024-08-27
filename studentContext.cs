using Microsoft.EntityFrameworkCore;

namespace StudentApp
{
    public class StudentContext : DbContext
    {
        // Define the connection string to the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDb;Trusted_Connection=True;");
        }

        // DbSet representing the Students table in the database
        public DbSet<Student> Students { get; set; }
    }
}