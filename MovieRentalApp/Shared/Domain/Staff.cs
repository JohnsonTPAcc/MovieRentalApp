using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? StaffName { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string? StaffEmail { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Password { get; set; }

        // Add other properties and annotations as necessary
    }
}
