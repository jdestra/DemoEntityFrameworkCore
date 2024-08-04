using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameworkCore
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                "Server=LAPTOP-UL8JHP4F\\SQLDEV;Initial Catalog=DemoEFCoreUdemy;Integrated Security=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
