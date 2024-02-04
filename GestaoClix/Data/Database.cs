using GestaoClix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
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

        private static Database? instance = null;

        public static Database getInstance()
        {
            if (instance == null)
                instance = new Database();

            return instance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Lagostim"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
