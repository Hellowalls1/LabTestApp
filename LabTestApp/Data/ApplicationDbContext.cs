

using LabTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        //connection for each table 

        public DbSet<LabTest> LabTest { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<UserProfile> User { get; set; }

  

    }
}
