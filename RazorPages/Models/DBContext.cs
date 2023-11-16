using Microsoft.EntityFrameworkCore;

namespace RazorPages.Models
{
    public class DBContext : DbContext
    {
        
        public DbSet <Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MemoryDB");
            
        }
    }
}
