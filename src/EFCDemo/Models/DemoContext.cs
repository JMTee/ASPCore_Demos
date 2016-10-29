using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCDemo.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions options):base(options)
        {

        }
        
        // These properties represent will represent your models in the database. 
        // if you want to interact with Account or Purchase table, you just need to use these properties.
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("<---insert connection string here--->");

            //insert connection string like the one below
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Demo1Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
    }
}
