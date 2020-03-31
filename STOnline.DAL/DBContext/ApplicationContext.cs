using Microsoft.EntityFrameworkCore;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Model;
using STOnline.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.DBContext
{
    public class ApplicationContext: DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerCategory> WorkerCategories { get; set; }


    }
}
