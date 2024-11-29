using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AQAutosMVC.Models;

    public class AQAutosContext : DbContext
    {
        public AQAutosContext (DbContextOptions<AQAutosContext> options)
            : base(options)
        {
        }

        public DbSet<AQAutosMVC.Models.AQAuto> AQAuto { get; set; } = default!;
    }
