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
    public class filmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(

                new Film() { Id = 1, Name = "Recep İvedik", Type = "Komedi", IMDB = 5 },
                new Film() { Id = 2, Name = "Recep İvedik 2", Type = "Komedi", IMDB = 6 },
                new Film() { Id = 3, Name = "Recep İvedik 3", Type = "Komedi", IMDB = 7 }
                );
        }
    }
}
