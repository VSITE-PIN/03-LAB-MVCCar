using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCar.Models;

    public class MVCCar1 : DbContext
    {
        public MVCCar1 (DbContextOptions<MVCCar1> options)
            : base(options)
        {
        }

        public DbSet<MVCCar.Models.Car> Car { get; set; } = default!;
    }
