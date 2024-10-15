using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEMOMPMVC.Models;


namespace DEMOMPMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {          
        }
        public DbSet<DEMOMPMVC.Models.Employee> Employee { get; set; } = default!;
    }
}
