using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User() { UserId = 1, UserName = "alidegirmenci", Password = "123", Email = "alideg41", Phone = "5553108585" },
                new User() { UserId = 2, UserName = "emirturanali", Password = "456", Email = "turanali41", Phone = "5553108586" },
                new User() { UserId = 3, UserName = "velidasn", Password = "789", Email = "velidasan43", Phone = "5553108587" }
                );
        }
    }
}
