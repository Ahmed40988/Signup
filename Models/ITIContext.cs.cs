using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ITIContext : DbContext
    {
        public ITIContext(DbContextOptions<ITIContext> options) : base(options) { }

        public DbSet<Signup> Signup { get; set; }
    }
}
