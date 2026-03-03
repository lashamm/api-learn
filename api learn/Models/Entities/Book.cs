using api_learn.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_learn.Models.Entities
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = string.Empty;

        [Column("description")]
        [StringLength(1500, MinimumLength = 1)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column("price", TypeName ="decimal(5,2)")]
        public decimal Price { get; set; }
        [Required]
        [Column("author")]
        [StringLength(300, MinimumLength = 1)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [Column("release_year")]
        [Range (1450, 2100)]
        public int ReleaseYear { get; set; }

        [Required]
        [Column("genre")]
        public Genre Genre { get; set; }

        [Required]
        [Column("pages")]
        [Range(1, 10000)]
        public int Pages { get; set; }

        [Required]
        [Column("publication")]
        [StringLength(300, MinimumLength = 1)]
        public string Publication { get; set; } = string.Empty;

        [Column("quantity")]
        [Range(0, 500)]
        public int Quantity { get; set; }

        [NotMapped]
        public bool IsAvailable { get => Quantity > 0; }

        [Required]
        [Column("isbn")]
        [StringLength(13, MinimumLength = 10)]
        public string ISBN { get; set; } = string.Empty;

        [Column("editor")]
        [StringLength(300, MinimumLength = 1)]
        public string Editor { get; set; } = string.Empty;

        [Required]
        [Column("language")]
        public Language Language { get; set; }

        [Required]
        [Column("translator")]
        [StringLength(300, MinimumLength = 1)]
        public string? Tralator { get; set; }

        [Required]
        [Column("is_original")]
        public bool IsOriginal { get; set; }
        }
}
