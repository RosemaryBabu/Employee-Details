using Microsoft.EntityFrameworkCore;
using NetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.DataBase
{
    public class EmployeeEntity :DbContext
    {
        public EmployeeEntity(DbContextOptions<EmployeeEntity> options):base (options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
