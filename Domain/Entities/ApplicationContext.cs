using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Leads> Leads { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Society> Society { get; set; }
    }
}
