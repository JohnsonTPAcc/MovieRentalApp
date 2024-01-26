using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        // Assuming Age is an integer. If it's a different type, adjust accordingly.
        public int Age { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Password { get; set; }

        // Assuming Student is a boolean indicating whether the customer is a student or not.
        public bool Student { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(500)]
        public string? Address { get; set; }

        // Assuming Approval is a boolean indicating whether the customer is approved or not.
        public bool Approval { get; set; }

        // Add other properties and annotations as necessary
    }
}