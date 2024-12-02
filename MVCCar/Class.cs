namespace MVCCars
{
    using Microsoft.EntityFrameworkCore;

    namespace MVCCars.Models // Ovdje prilagodite prostor imena prema svom projektu
    {
        public class ApplicationDbContext : DbContext
        {
            // DbSet za entitet Car
            public DbSet<Cars> Cars { get; set; }

            // Konstruktor za konfiguraciju DbContext-a
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
    }
}
