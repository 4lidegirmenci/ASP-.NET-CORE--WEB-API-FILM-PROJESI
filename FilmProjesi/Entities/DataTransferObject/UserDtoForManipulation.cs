using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObject
{
    public abstract record UserDtoForManipulation
    {
        [Required(ErrorMessage = " UserName is required field.")]
        [MinLength(2, ErrorMessage = "UserName must consist of at least 2 characters")]
        [MaxLength(50, ErrorMessage = "UserName must consist of at least 50 characters")]
        public string UserName { get; init; }

        [Required(ErrorMessage = "Phone is required field.")]
        [MinLength(2, ErrorMessage = "Phone must consist of at least 2 characters")]
        [MaxLength(11, ErrorMessage = "Phone must consist of at least 11 characters")]
        public string Phone { get; init; }

        [Required]
        public string Password { get; init; }

        [Required]

        public string Email { get; init; }
    }
}
