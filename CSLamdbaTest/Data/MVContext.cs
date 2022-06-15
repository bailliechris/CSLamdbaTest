using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSLamdbaTest.Models;

namespace CSLamdbaTest.Data
{
    public class MVContext : DbContext
    {
        public MVContext ()
        {

        }

        public MVContext(DbContextOptions<MVContext> options) : base(options) { }

        // Define tables (using models)
        public DbSet<Bio> Bios { get; set; } = null!;

        // When doing migrations!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=biotest.crtoxtekpnou.eu-central-1.rds.amazonaws.com,1433;Database=biotest;User ID=admin;Password=G3oseEueVTWJT1V2VuMA;");
            }
        }

        // Setting relationships between tables with foriegn keys etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);
            });*/
        }
    }
}
