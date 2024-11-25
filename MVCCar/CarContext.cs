using Microsoft.EntityFrameworkCore;
using MVCCar.Models;

namespace MVCCar
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

    }
}
