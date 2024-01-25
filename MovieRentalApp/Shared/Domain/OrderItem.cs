using MovieRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        [Required]
        public int Qty { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceEach { get; set; }

        public DateTime LastUpdated { get; set; }

        // Foreign key for Order
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        // Navigation property for Order
        public virtual Order? Order { get; set; }
    }
}
