using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_learn.Models.DTOs
{
    public class AuthorCreateDTO
    {

        [Required]
        [StringLength(150, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(1500, MinimumLength = 1)]
        public string Bio { get; set; } = string.Empty;
    }
}
