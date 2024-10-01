using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhMPmvc.Models;


namespace MinhMPmvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {          
        }
        public DbSet<MinhMPmvc.Models.Employee> Employee { get; set; } = default!;
    }
}
