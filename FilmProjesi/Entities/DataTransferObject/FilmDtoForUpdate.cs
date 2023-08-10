using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObject
{
    public record FilmDtoForUpdate : FilmDtoForManipulation
    {
        [Required]
        public int Id { get; init; }

       
    }

}
