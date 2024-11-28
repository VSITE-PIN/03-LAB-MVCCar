using Microsoft.EntityFrameworkCore;

public class MVCCarContext : DbContext
{
    public MVCCarContext(DbContextOptions<MVCCarContext> options)
        : base(options)
    {
    }

    public DbSet<MVCCar.Models.Car> Cars { get; set; } = default!;
}
