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
    public class Payment : BaseDomainModel
    {
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        // Assuming RentalID is a foreign key for a Rental entity
        [ForeignKey("Rental")]
        public int RentalID { get; set; }
        public virtual Rental Rental { get; set; }

        // Assuming MovieID is a foreign key for a Movie entity
        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

        // Assuming UserID is a foreign key for a User entity (like Customer or Staff)
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        // Assuming StaffID is a foreign key for a Staff entity
        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }

        // Foreign key for Order - This seems like an unusual relationship.
        // If Payment is linked to an Order, then RentalID and MovieID may not be necessary.
        // This depends on the specific design of your system.
        [ForeignKey("Order")]
        public int? OrderID { get; set; } // Nullable if not every payment is associated with an order
        public virtual Order Order { get; set; }
    }
}