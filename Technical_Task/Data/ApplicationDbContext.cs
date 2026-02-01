using Microsoft.EntityFrameworkCore;
using Technical_Task.Models;

namespace Technical_Task.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<User> users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
    }
}
