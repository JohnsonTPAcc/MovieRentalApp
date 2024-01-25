using MovieRentalApp.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime RequiredDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceEach { get; set; }

        public DateTime LastUpdated { get; set; }

        // Additional properties and navigation properties can be added as needed
    }
}