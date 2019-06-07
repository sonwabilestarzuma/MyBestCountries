using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBestCountries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBestCountries.Data
{
    public class MyContriesContext : IdentityDbContext<ApplicationUser>
    {
        public MyContriesContext(DbContextOptions<MyContriesContext> options)
            : base(options)
        { }

        public DbSet<Visit> Visits { get; set; }
    }
}
