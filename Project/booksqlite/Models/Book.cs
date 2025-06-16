using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booksqlite.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [MaxLength(13)]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty ;
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime PublishedDate { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; } = null!;
    }
}
