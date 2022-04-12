using Controller.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller.DataBase
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=TransportCompany;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
    }
}
