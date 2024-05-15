using CascadingTask.Models.DbEntites;
using Microsoft.EntityFrameworkCore;

namespace CascadingTask.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        
        public DbSet<State> States { get; set; }
        
        public DbSet<City> Citys { get; set; }
    }
}
