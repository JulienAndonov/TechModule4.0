using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;
using Microsoft.EntityFrameworkCore;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext : DbContext
    {

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4SV7N2B\\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security = true");
        }
    }
}