using MovieRentalManagement.Shared.Domain;

namespace MovieRentalApp.Shared.Domain
{
    public class Rental : BaseDomainModel
    {
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable in case the movie has not been returned yet
        public decimal RentalPrice { get; set; }
        public decimal? LateFee { get; set; } // Nullable in case there is no late fee

        // Navigation property to the Movie entity
        public virtual Movie? Movie { get; set; }
        public int MovieId { get; set; } // Foreign key to the Movie table

        // Navigation property to the Customer entity
        public virtual Customer? Customer { get; set; }
        public int CustomerId { get; set; } // Foreign key to the Customer table
       
    }
}