using Microsoft.EntityFrameworkCore;

namespace RazorLiveDemoPowerpoint.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }

}
