
using Microsoft.EntityFrameworkCore;
using MVCCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MVCCarContext : DbContext
{
    public MVCCarContext(DbContextOptions<MVCCarContext> options)
        : base(options)
    {
    }

    public DbSet<Car> Car { get; set; } = default!;
}
