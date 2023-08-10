using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }


        public decimal IMDB { get; set; }
    }
}
