﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCar.Models;

namespace MVCCar.Data
{
    public class MVCCarContext : DbContext
    {
        public MVCCarContext (DbContextOptions<MVCCarContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCar.Models.Carcs> Carcs { get; set; } = default!;
    }
}
