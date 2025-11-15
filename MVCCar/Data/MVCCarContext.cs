using Microsoft.EntityFrameworkCore;
using MVCCar.Models;

namespace MVCCar.Data
{
    public class MVCCarContext : DbContext
    {
        public MVCCarContext(DbContextOptions<MVCCarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = default!;
    }
}
