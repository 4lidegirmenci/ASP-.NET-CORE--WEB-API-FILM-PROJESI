using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObject
{
    public abstract record FilmDtoForManipulation
    {
        [Required(ErrorMessage = "Name is required field.")]
        [MinLength(2,ErrorMessage ="Name must consist of at least 2 characters")]
        [MaxLength(50,ErrorMessage ="Name must consist of at least 50 characters")]
        public string Name { get; init; }

        [Required(ErrorMessage ="IMDB is required field.")]
        [Range(0,10)]

        public int IMDB { get; init; }

        [Required]
        public string Type { get; init; }
    }
}
