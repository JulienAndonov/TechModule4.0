using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BandRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace BandRegister.Data
{
    public class BandRegisterDbContext : DbContext
    {

        public DbSet<Band> Bands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4SV7N2B\\SQLEXPRESS;Database=BandRegisterDBb;Integrated Security = true");
        }
    }
}
