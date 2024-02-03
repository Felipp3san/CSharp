using GestaoClix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Data
{
    internal class Database : DbContext
    {
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Movimento>? Movimento { get; set; }
        public DbSet<Tipo>? Tipo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Lagostim"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
