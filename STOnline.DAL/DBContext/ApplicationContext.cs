using Microsoft.EntityFrameworkCore;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STOnline.DAL.DBContext
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerCategory> WorkerCategories { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ANDREYKOT\SQLEXPRESS;Database=stonline3;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany(c => c.Orders);
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Category)
                .WithMany(o => o.Orders);
            modelBuilder.Entity<Repair>()
                .HasOne(r => r.Order)
                .WithMany(o => o.Repairs);
            modelBuilder.Entity<Repair>()
                .HasOne(r => r.Worker)
                .WithMany(o => o.Repairs);
            modelBuilder.Entity<WorkerCategory>()
                .HasOne(w => w.Worker)
                .WithMany(c => c.WorkerCategoryes);
            modelBuilder.Entity<WorkerCategory>()
                .HasOne(w => w.Category)
                .WithMany(c => c.WorkerCategories);


        }

    }
}
