using Microsoft.EntityFrameworkCore;
using MVCCar.Models;

namespace MVCCar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }       
    }
}
