using DataStatsMVC.Areas.Identity;
using DataStatsMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStatsMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Call> Calls { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // keys of Identity tables are mapped in OnModelCreating method of IdentityDbContext
            // and if this method is not called, you will get an error saying 'IdentityUserLogin<string>
            // requires a primary key to be defined.
            base.OnModelCreating(builder);

        }
    }
}
