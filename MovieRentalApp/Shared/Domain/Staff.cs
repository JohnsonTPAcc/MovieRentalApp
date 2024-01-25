using MovieRentalApp.Shared.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentalManagement.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        public string? StaffName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? StaffEmail { get; set; }

        [Required]
        public string? Username { get; set; }

        public DateTime LastUpdated { get; set; }

        // Additional properties and navigation properties can be added as needed
    }
}
