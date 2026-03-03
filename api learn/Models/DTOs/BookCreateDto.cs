using api_learn.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_learn.Models.DTOs
{
    public class BookCreateDto
    {
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1500, MinimumLength = 1)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 1)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [Range(1450, 2100)]
        public int ReleaseYear { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Pages { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 1)]
        public string Publication { get; set; } = string.Empty;

        [Range(0, 500)]
        public int Quantity { get; set; }

        [NotMapped]
        public bool IsAvailable { get => Quantity > 0; }

        [Required]
        [StringLength(13, MinimumLength = 10)]
        public string ISBN { get; set; } = string.Empty;

        [StringLength(300, MinimumLength = 1)]
        public string Editor { get; set; } = string.Empty;

        [Required]
        public Language Language { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 1)]
        public string? Tralator { get; set; }

        [Required]
        public bool IsOriginal { get; set; }
    }
}
