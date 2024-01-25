using MovieRentalApp.Shared.Domain;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        public string? Name { get; set; }

        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public bool Student { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public bool Approval { get; set; }



        // Navigation property to the Rental entity
        // Assuming a customer can have multiple rentals
        public virtual List<Rental>? Rentals { get; set; }
    }
}