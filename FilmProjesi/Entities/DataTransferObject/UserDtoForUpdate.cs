using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObject
{
    public record UserDtoForUpdate : UserDtoForManipulation
    {
        [Required]
        public int UserId { get; init; }

       
    }

}
