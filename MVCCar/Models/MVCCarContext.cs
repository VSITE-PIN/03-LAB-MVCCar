using Microsoft.EntityFrameworkCore;

namespace MVCCar.Models
{
    public class MVCCarContext : DbContext
    {
        public MVCCarContext(DbContextOptions<MVCCarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}