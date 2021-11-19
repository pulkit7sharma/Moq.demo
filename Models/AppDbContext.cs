using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moq.Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void  OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee { designation = "manager", id = 1, name = "Pulkit" },
                new Employee { designation = "Developer" ,id = 2, name = "thepulkit" },
                new Employee { designation = "tester", id = 3, name = "Pulkit2" }
                ) ;
        }
    }
}
