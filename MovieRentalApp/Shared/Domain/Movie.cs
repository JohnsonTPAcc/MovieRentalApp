using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Shared.Domain
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        // Assuming Duration is stored in minutes as an integer. Adjust the type if necessary.
        public int Duration { get; set; }

        [MaxLength(50)]
        public string? Rating { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        // Assuming Rental_Price is a decimal to accommodate currency values.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal RentalPrice { get; set; }

        // Assuming Rental_Duration is an integer representing the number of days for rental.
        public int RentalDuration { get; set; }

        // Add other properties and annotations as necessary
    }
}