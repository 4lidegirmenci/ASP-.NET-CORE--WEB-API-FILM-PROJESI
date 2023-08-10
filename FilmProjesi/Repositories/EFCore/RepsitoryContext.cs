using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepsitoryContext
    {
        public class RepositoryContext : DbContext
        {
            public DbSet<Film> Films { get; set; }
            public DbSet<User> Users { get; set; }



            public RepositoryContext(DbContextOptions options) : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new filmConfig());
                modelBuilder.ApplyConfiguration(new UserConfig());
            }





        }
    }
}
