using EnterPrice.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterPrice.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Worker> Wokers { get; set; }
        public DbSet<Building> Buidings { get; set; }
        public DbSet<Asigment> Asigments { get; set; }
    }
}
